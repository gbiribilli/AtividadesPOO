
Reptil roberto = new Reptil("Dragão de Komodo", 50, 1.20, "Mato");
Reptil Indominus = new Reptil("Indominus-Rex", 1, 3, "Todos");

Mamifero goat = new Mamifero("Cabra", 5, "Branco", "Grama");
Mamifero pig = new Mamifero("Porco", 6, "Rosa", "Fezes");

Ave loro = new Ave("Arara", 10, "Verde-Amarelo", "Sustenção");
Ave gaviao = new Ave("Gaviões da fiel", 105, "Preto-Branco", "Ativo");

Reptil r = new Reptil("Dragão de Komodo", 50, 1.20, "Mato");

Zoologico z = new Zoologico();

z.adicionarAnimal(roberto);
z.adicionarAnimal(Indominus);
z.adicionarAnimal(goat);
z.adicionarAnimal(pig);
z.adicionarAnimal(loro);
z.adicionarAnimal(gaviao);
z.adicionarAnimal(r);

VisitanteRapido VP = new VisitanteRapido();

VisitanteLento VL = new VisitanteLento();

VP.Visitar(z);
VL.Visitar(z);

z.ObservarAnimal(5);

