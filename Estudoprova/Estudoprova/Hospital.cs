namespace Estudoprova;

public class Hospital
{
    private List<Paciente> listaDePacientes = new List<Paciente>();
    
    public void AdmitirPaciente(Paciente paciente)
    {
        listaDePacientes.Add(paciente);
    }

    public void DarAlta(Paciente paciente)
    {
        listaDePacientes.Remove(paciente);
    }

    public List<Paciente> BuscarPaciente(string  nome)
    {
        List<Paciente> pacientes = new List<Paciente>();
        foreach (var paciente in listaDePacientes)
        {
            if (paciente.Nome == nome)
            {
                pacientes.Add(paciente);
            }
        }
        return pacientes;
    }

    public List<Paciente> BuscarPaciente(string tipoProblema, bool estadoPaciente)
    {
        List<Paciente>pacientes = new List<Paciente>();
        foreach (var paciente in listaDePacientes)
        {
            if (paciente.TipoProblema== tipoProblema && (paciente is Emergencia p && p.EstadoGrave))
            {
                pacientes.Add(paciente);
            }
        }
        return pacientes;
    }

    public void Descrever()
    {
        foreach (var paciente in listaDePacientes)
        {
            Console.Write($"{paciente.Nome} - {paciente.Idade} -  {paciente.TipoProblema} -");
            switch (paciente)
            {
                case Internado internado:
                    Console.WriteLine($" {internado.InformacoesAdicionais()}"); 
                    break;
                case Emergencia emergencia:
                    Console.WriteLine($" {emergencia.InformacoesAdicionais()}");
                    break;
            }
        }
    }
}