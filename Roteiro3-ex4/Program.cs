using System;

public interface IAnimal {
    void Voar();
    void Nadar();
}

public class Pato : IAnimal {
    public void Voar() {
        Console.WriteLine("Pato esta voando!");
    }
    public void Nadar() {
        Console.WriteLine("Pato esta nadando!");
    }
}

public class Aguia : IAnimal {
    public void Voar() {
        Console.WriteLine("Aguia esta voando!");
    }
    public void Nadar() {
        Console.WriteLine("Aguia nao pode nadar!");
    }
}

public class Peixe : IAnimal {
    public void Voar() {
        Console.WriteLine("Peixe nao pode voar!");
    }
    public void Nadar() {
        Console.WriteLine("Peixe esta nadando!");
    }
}

public class Program {
    public static void Main() {
        IAnimal pato = new Pato();
        IAnimal aguia = new Aguia();
        IAnimal peixe = new Peixe();

        pato.Nadar();
        pato.Voar();

        aguia.Nadar();
        aguia.Voar();

        peixe.Nadar();
        peixe.Voar();
    }
}