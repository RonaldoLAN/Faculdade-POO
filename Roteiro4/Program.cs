using System;

public class Pagamento {
    public virtual void ProcessarPagamento() {
        Console.WriteLine("Pagamento");
    }
}

class CartaoCredito : Pagamento {
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento feito com Cartao de Credito");
    }
}

class BoletoBancario : Pagamento {
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento feito com Boleto bancario");
    }
}

class Pix : Pagamento {
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento feito com Pix");
    }
}

public class Program {
    public static void Main() {
        List<Pagamento> pagamentos = new List<Pagamento>
        {
            new CartaoCredito(),
            new BoletoBancario(),
            new Pix()
        };

        foreach (var pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento();
        }
    }
}