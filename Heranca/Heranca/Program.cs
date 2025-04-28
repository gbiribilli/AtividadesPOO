using System.Reflection.Metadata.Ecma335;
using Heranca;

cachorro dog = new cachorro("Gohst", "Preto","Cachorro", "auau", "casa");
gato cat = new gato("frida", "preto", "Gato", "miau miau", "casa");

dog.andar();
dog.andar();
dog.andar();
dog.descanso();
Console.WriteLine("\n");
cat.andar();
cat.dormir();
cat.acordar();
Console.WriteLine("\n");

dog.mostrarCaracteriscas();
cat.mostrarCaracteriscas();
