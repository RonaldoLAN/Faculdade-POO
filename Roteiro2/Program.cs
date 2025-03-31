
using System;

public class Produto {
    
    private string  Nome {get; set;}
    private double Preco;

    public Produto(string nome, double preco) {
        Nome = nome;
        Preco = preco;
    }

    public double preco {
        get {return Preco;}

        set {
            if (preco < 0) {
                Console.WriteLine("Preco invalido");
            }
        }
    }

    public void ExibirDetalhes() {
        Console.WriteLine($"O PRODUTO E {Nome} E O PRECO {Preco}");
    }

}

public class Program {
    public static void Main(){
        Produto produto1 = new Produto("Celular", 1500);
        produto1.ExibirDetalhes();
        produto1.Preco = -200;
    }
}
