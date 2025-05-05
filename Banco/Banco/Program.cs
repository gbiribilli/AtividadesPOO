ContaCorrente cc = new ContaCorrente("Biribilli", 10000);
ContaPoupanca co = new ContaPoupanca("Guilherem", 100000);
ContaInvestimento ci = new ContaInvestimento("ASDA", 1000000);

cc.Sacar(500);
Console.WriteLine();
cc.Manutencao();
Console.WriteLine();
cc.Depositar(200);
Console.WriteLine();
cc.CalcularJuros(1000, 90);
Console.WriteLine();

co.Sacar(50000);
Console.WriteLine();
co.CalcularJuros(1000, 90);
Console.WriteLine();
co.Sacar(212);
Console.WriteLine();

ci.investir(500);
Console.WriteLine();
ci.Sacar(1000);
Console.WriteLine();
ci.Depositar(100);
Console.WriteLine();
ci.verificarInvestimento();
ci.verificarInvestimento();
ci.verificarInvestimento();
Console.WriteLine();
ci.retirarInvestimento();
