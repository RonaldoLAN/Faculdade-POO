using System;

public abstract class Funcionario
{
    public string Nome { get; set; }
    public abstract double CalcularSalario();
}

public class Gerente : Funcionario
{
    private double salarioBase;
    private double bonus;
    
    public Gerente(string nome, double salarioBase, double bonus)
    {
        Nome = nome;
        this.salarioBase = salarioBase;
        this.bonus = bonus;
    }
    
    public override double CalcularSalario()
    {
        return salarioBase + bonus;
    }
}

public class Programador : Funcionario
{
    private double salarioBase;
    private double horaExtra;
    private int horasTrabalhadas;
    
    public Programador(string nome, double salarioBase, double horaExtra, int horasTrabalhadas)
    {
        Nome = nome;
        this.salarioBase = salarioBase;
        this.horaExtra = horaExtra;
        this.horasTrabalhadas = horasTrabalhadas;
    }
    
    public override double CalcularSalario()
    {
        return salarioBase + (horaExtra * horasTrabalhadas);
    }
}

class Program
{
    static void Main()
    {
        Funcionario gerente = new Gerente("Carlos", 5000, 2000);
        Funcionario programador = new Programador("Ana", 3000, 50, 10);
        
        Console.WriteLine($"Salário do Gerente {gerente.Nome}: {gerente.CalcularSalario():C}");
        Console.WriteLine($"Salário do Programador {programador.Nome}: {programador.CalcularSalario():C}");
    }
}
