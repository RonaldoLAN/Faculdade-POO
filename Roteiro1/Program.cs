using System;
public class Pessoa {
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar() {
        Console.WriteLine($"Ola, meu nome e {Nome} e tenho {Idade} anos. O meu cargo e {Cargo}");
    }

    public void meuSalario(string salario) {
        Console.WriteLine(salario);
    }
}

public class Program {
    public static void Main() {
        Pessoa p1 = new Pessoa();
        p1.Idade = 30;
        p1.Nome = "Joao";
        p1.Cargo = "Gerente";
        p1.Apresentar();
        p1.meuSalario("Meu salario e 10000");

        Pessoa p2 = new Pessoa();
        p2.Idade = 20;
        p2.Nome = "Jose";
        p2.Cargo = "Desenvolvedor";
        p2.Apresentar();
        p2.meuSalario("Meu salario e 1000");


        Pessoa p3 = new Pessoa();
        p3.Idade = 25;
        p3.Nome = "Janaina";
        p3.Cargo = "Estagiario";
        p3.Apresentar();
        p3.meuSalario("Meu salario e 100");

    }
}
