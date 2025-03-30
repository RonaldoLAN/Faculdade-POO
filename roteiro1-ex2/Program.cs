using System;

public class Fantasma {
    public string Nick;
    public string Cor;
    public string Habilidade;
    
    public void GerarFantasma() {
        Console.WriteLine($"Nome: {Nick} Cor: {Cor} Habilidade: {Habilidade}");
    }

    public void Mover(string direcao) {
        Console.WriteLine($"O {Nick} se moveu para {direcao}");
    }
}

public class Program {
    public static void Main() {
        Fantasma f1 = new Fantasma();
        f1.Nick = "Ronaldo";
        f1.Cor = "Vermelho";
        f1.Habilidade = "Soltar lazer";
        f1.GerarFantasma();
        f1.Mover("Direita");
    }
}
