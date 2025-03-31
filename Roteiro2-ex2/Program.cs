using System;

public class Carro {

    private string Modelo {get; set;}
    private int VelocidadeAtual;

    public Carro(string modelo){
        Modelo = modelo;
        VelocidadeAtual = 0;
    }

    public int velocidadeAtual {
        get {return VelocidadeAtual;}
    }

    public void Acelerar(int valor) {
        VelocidadeAtual += valor;
    }

    public void Frear(int valor) {
        VelocidadeAtual -= valor;
        if (VelocidadeAtual < 0) {
            VelocidadeAtual = 0;
        }
    }
}

public class Program {
    public static void Main() {

        Carro carro1 = new Carro("Ferrari");
        carro1.Acelerar(50);
        Console.WriteLine(carro1.velocidadeAtual);
        carro1.Frear(30);
        Console.WriteLine(carro1.velocidadeAtual);
        carro1.Frear(30);
        Console.WriteLine(carro1.velocidadeAtual);
    }
}