namespace SOLID.Console._2_OCP.Violacao;

public class Conta
{
    public string Numero { get; set; } = default!;
    public decimal Saldo { get; set; }
    public TipoConta TipoConta { get; set; }

    public void CalcularRendimento(decimal taxa)
    {
        switch (TipoConta)
        {
            case TipoConta.Corrente:
                // Calcula o rendimento em conta corrente
                break;
            case TipoConta.Poupanca:
                // Valida o aniversário da conta
                // Calcula o rendimento em conta poupança
                break;
            // Precisamos adicionar a conta de pagamento
        }
    }
}

public enum TipoConta
{
    Corrente,
    Poupanca
}