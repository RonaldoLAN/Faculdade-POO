using System;

public class Animal {
    public string Nome;

    public Animal(string nome) {
        Nome = nome;
    }

    public void EmitirSom() {
        Console.WriteLine("Som generico de animal!");
    }
}

public class Cachorro : Animal {

    public Cachorro(string nome) : base(nome) { }
    
    public void EmitirSom() {
        Console.WriteLine("AU AU AU!");
    }
}

public class Program {
    public static void Main() {
        Cachorro Bella = new Cachorro("Bella");
        Bella.EmitirSom();
    }
}

