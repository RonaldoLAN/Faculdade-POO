using System;

public class Elevador {
    
    private int andarAtual;
    private int totalAndares;

    public Elevador(){}

    public Elevador(int totalAndares) {
        this.andarAtual = 0;
        this.totalAndares = totalAndares;
    }

    public int AndarAtual {
        get {return andarAtual;}
        set {
            if (value >= 0 && value <= totalAndares) {
                andarAtual = value;
            }
        }
    }

    public int TotalAndares {
        get { return totalAndares;}
        set {
            if (value > 0) {
                totalAndares = value;
            } else {
                Console.WriteLine("O total de andares deve ser maior que zero!");
            }
        }
    }

    public void Subir() {
        if (AndarAtual < totalAndares) {
            AndarAtual++;
            Console.WriteLine("Subindo... Andar atual: " + AndarAtual);
        } else {
            Console.WriteLine("Você já está no último andar!");
        }
    }

    public void Descer() {
        if (AndarAtual > 0) {
            AndarAtual--;
            Console.WriteLine("Descendo... Andar atual: " + AndarAtual);
        } else {
            Console.WriteLine("Você já está no térreo!");
        }
    }

}

public class Program {
    public static void Main() {
        Elevador elevador1 = new Elevador(10);
        elevador1.Subir();
        elevador1.Subir();
        Console.WriteLine(elevador1.AndarAtual);
        elevador1.Descer();
        Console.WriteLine(elevador1.AndarAtual);
        elevador1.Descer();
        elevador1.Descer();
        Console.WriteLine(elevador1.AndarAtual);
    }
}