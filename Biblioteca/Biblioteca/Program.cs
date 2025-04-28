LivroInfantil l = new LivroInfantil("Pequeno Príncipe", "Alguem", 10);
LivroAcademico la = new LivroAcademico("Calculo1", "Einstein", "567890");
LivroInfantil ls = new LivroInfantil("Pequeno", "Alguem", 8);
LivroAcademico ld = new LivroAcademico("Calculo3", "ronaldo", "57890");

biblioteca b = new biblioteca();

b.Livros.Add(ls);
b.Livros.Add(ld);
b.Livros.Add(la);
b.Livros.Add(l);

b.buscarLivro("567890");
Console.WriteLine();
b.buscarLivro(10);
Console.WriteLine();
b.buscarLivro("23123");
