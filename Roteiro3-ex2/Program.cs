using System;

public class Item {

    public string Nome;
    public int Valor;

    public void MostrarItem() {
        Console.WriteLine($"Seu produto e {Nome} e o valor {Valor}");
    }


}

public class Pedido {

    private Item item;

    public Pedido() {
        item = new Item();
    }

    public void MostrarPedido() {
        Console.WriteLine("Seu pedido foi feito");
        item.MostrarItem();
    }
}


public class Program {
    public static void Main() {
        Pedido pedido = new Pedido();
        pedido.MostrarPedido();
    }
}