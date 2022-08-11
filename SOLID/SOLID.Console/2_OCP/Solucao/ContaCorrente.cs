namespace SOLID.Console._2_OCP.Solucao;

public class ContaCorrente : Conta
{
    public override void CalcularRendimento(decimal taxa)
    {
        Saldo *= (1 + taxa / 2);
    }
}
