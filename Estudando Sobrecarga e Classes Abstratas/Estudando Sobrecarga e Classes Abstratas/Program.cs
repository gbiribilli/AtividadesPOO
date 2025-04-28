Programador p = new Programador("Biribilli", 230.4);
Gerente g = new Gerente("Renato", 2000);
Designer d = new Designer("Sandro", 1500);

Empresa empresa = new Empresa();

empresa.funcionarios.Add(g);
empresa.funcionarios.Add(d);
empresa.funcionarios.Add(p);

empresa.listarFuncionario();
Console.WriteLine();
empresa.trabalharF();
Console.WriteLine();
empresa.darAumento();
Console.WriteLine();
empresa.listarFuncionario();