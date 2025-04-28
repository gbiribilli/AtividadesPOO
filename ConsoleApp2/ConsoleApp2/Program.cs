using ConsoleApp2;

/*Agenda agenda1 = new Agenda("Guilherme", 102391);

agenda1.adicionarAgenda("Deborah", 18210);
agenda1.adicionarAgenda("Enzo", 112310);
agenda1.adicionarAgenda("Borba", 1812310);
agenda1.adicionarAgenda("Lucas", 182120);

agenda1.mostrarAgenda();
Console.WriteLine("\n");
agenda1.removerAgenda("Borba");
agenda1.mostrarAgenda();
Console.WriteLine("\n");
agenda1.buscarAgenda("Enzo");*/

/*Caixa caixa1 = new Caixa("Biri", "1423");
caixa1.deposito(200);
caixa1.sacar(100);
caixa1.verConta();
Console.Write("\n");
caixa1.extratoConta();*/
Elevador e = new Elevador();
UsuarioElevador u = new UsuarioElevador("biri", 80, e);

u.EntrarNoElevador();


