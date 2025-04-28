using System;
using System.Collections.Generic;
using System.Threading;

class Computador
{
    public CPU Cpu;
    public MemoriaRAM Ram;
    public HD Hd;
    public PlacaDeVideo PlacaDeVideo;
    public FonteDeAlimentacao Fonte;

    public bool Inicializar()
    {
        List<string> falhas = new List<string>();

        if (!Cpu.Inicializar()) falhas.Add("CPU");
        if (!Ram.Inicializar()) falhas.Add("Memória RAM");
        if (!Hd.Inicializar()) falhas.Add("HD");
        if (!PlacaDeVideo.Inicializar()) falhas.Add("Placa de Vídeo");
        if (!Fonte.Inicializar()) falhas.Add("Fonte de Alimentação");

        if (falhas.Count > 0)
        {
            Console.WriteLine("Falha na inicialização:");
            foreach (var falha in falhas)
            {
                Console.WriteLine($"- {falha}");
            }
            return false;
        }

        return true;
    }

    public void MostrarConfiguracoes()
    {
        Console.WriteLine("Configurações do Computador:");
        Console.WriteLine($"CPU: {Cpu.Nucleos} núcleos, {Cpu.VelocidadeClock} GHz");
        Console.WriteLine($"Memória RAM: {Ram.Capacidade} bytes, tempo de apagamento: {Ram.TempoApagar} segundos");
        Console.WriteLine($"HD: {Hd.Capacidade} bytes, Tempo de escrita: {Hd.TempoEscrita} ms");
        Console.WriteLine($"Placa de Vídeo: {PlacaDeVideo.CapacidadeMemoria} bytes");
        Console.WriteLine($"Fonte de Alimentação: {Fonte.Potencia} watts");
    }
}

class CPU
{
    public int Nucleos { get; set; }
    public double VelocidadeClock { get; set; } // GHz
    public DateTime DataFabricacao { get; set; }

    public bool Inicializar()
    {
        double chanceFalha = (DateTime.Now.Year - DataFabricacao.Year) * 0.05;
        Random rand = new Random();
        double chanceAleatoria = rand.NextDouble();

        return chanceAleatoria > chanceFalha;
    }
}

class MemoriaRAM
{
    public long Capacidade; // bytes
    public int TempoApagar; // segundos
    public DateTime DataFabricacao;

    public bool Inicializar()
    {
        double chanceFalha = (DateTime.Now.Year - DataFabricacao.Year) * 0.05;
        Random rand = new Random();
        double chanceAleatoria = rand.NextDouble();

        return chanceAleatoria > chanceFalha;
    }
}

class HD
{
    public long Capacidade { get; set; } // bytes
    public int TempoEscrita { get; set; } // ms
    public bool IsSSD { get; set; }
    public DateTime DataFabricacao { get; set; }

    public bool Inicializar()
    {
        double chanceFalha = (DateTime.Now.Year - DataFabricacao.Year) * 0.05;
        Random rand = new Random();
        double chanceAleatoria = rand.NextDouble();

        if (IsSSD)
        {
            chanceFalha *= 0.5; // SSD tem menos chance de falha
        }

        return chanceAleatoria > chanceFalha;
    }
}

class PlacaDeVideo
{
    public long CapacidadeMemoria { get; set; } // bytes
    public DateTime DataFabricacao { get; set; }

    public bool Inicializar()
    {
        double chanceFalha = (DateTime.Now.Year - DataFabricacao.Year) * 0.05;
        Random rand = new Random();
        double chanceAleatoria = rand.NextDouble();

        return chanceAleatoria > chanceFalha;
    }
}

class FonteDeAlimentacao
{
    public int Potencia { get; set; } // watts
    public DateTime DataFabricacao { get; set; }

    public bool Inicializar()
    {
        double chanceFalha = (DateTime.Now.Year - DataFabricacao.Year) * 0.05;
        Random rand = new Random();
        double chanceAleatoria = rand.NextDouble();

        return chanceAleatoria > chanceFalha;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando os componentes com dados fictícios
        Computador computador = new Computador
        {
            Cpu = new CPU { Nucleos = 8, VelocidadeClock = 3.5, DataFabricacao = new DateTime(2020, 5, 1) },
            Ram = new MemoriaRAM { Capacidade = 16L * 1024L * 1024L * 1024L, TempoApagar = 30, DataFabricacao = new DateTime(2021, 6, 1) },
            Hd = new HD { Capacidade = 1L * 1024L * 1024L * 1024L * 1024L, TempoEscrita = 100, IsSSD = true, DataFabricacao = new DateTime(2021, 2, 1) },
            PlacaDeVideo = new PlacaDeVideo { CapacidadeMemoria = 8L * 1024L * 1024L * 1024L, DataFabricacao = new DateTime(2019, 10, 1) },
            Fonte = new FonteDeAlimentacao { Potencia = 650, DataFabricacao = new DateTime(2018, 3, 1) }
        };

        // Inicializando o computador
        if (computador.Inicializar())
        {
            Console.WriteLine("Computador ligado com sucesso!");
            computador.MostrarConfiguracoes();
        }
        else
        {
            Console.WriteLine("Não foi possível ligar o computador.");
        }
    }
}
