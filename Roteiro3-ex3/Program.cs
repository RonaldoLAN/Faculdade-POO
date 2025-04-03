using System;

public interface IVeiculo {
    void Mover();
}

public class Carro : IVeiculo {
    public void Mover() {
        Console.WriteLine("Carro esta se movendo");
    }
}

public class Bicicleta : IVeiculo {
    public void Mover() {
        Console.WriteLine("Bicicleta esta se movendo");
    }
}

public class Program {
    public static void Main() {
        IVeiculo carro1 = new Carro();
        IVeiculo bicicleta1 = new Bicicleta();

        carro1.Mover();
        bicicleta1.Mover();
    }
}