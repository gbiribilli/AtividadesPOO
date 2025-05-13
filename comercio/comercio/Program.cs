Alimento fruta = new Alimento("Fruta","12/05/2025",3.50);
Roupa Esportivo = new Roupa("Esportivo", "GG", 150);
Eletronico Samsung = new Eletronico("Samsung", "Galaxy S28", 10000);

Loja1 loja1 = new Loja1();
loja1.Estocar(fruta);
loja1.Estocar(Esportivo);
loja1.Estocar(Samsung);
Console.WriteLine();
loja1.listarProdutos();

Loja2 loja2 = new Loja2();
loja2.Estocar(fruta);
loja2.Estocar(Esportivo);
loja2.Estocar(Samsung);
Console.WriteLine();
loja2.listarProdutos();
Console.WriteLine();
loja2.VenderProduto(fruta);
Console.WriteLine();
loja1.VenderProduto(Samsung);
Console.WriteLine();
loja2.listarProdutos();
Console.WriteLine();
loja1.listarProdutos();
