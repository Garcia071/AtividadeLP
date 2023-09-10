using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro();
        cachorro.Nome = "Dog";
        cachorro.Tipo = "Mamifero";
        Console.WriteLine(cachorro);
        Console.WriteLine(cachorro.Pular());
        Console.WriteLine(cachorro.SomEmitido());

        Tartaruga tartaruga = new Tartaruga();
        tartaruga.Nome = "Turtle";
        tartaruga.Tipo = "Réptil";
        Console.WriteLine(tartaruga);
        Console.WriteLine(tartaruga.SomEmitido());
    }
}
