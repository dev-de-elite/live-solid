using SOLID.Console._2_OCP.Solucao_extensao;

namespace SOLID.Console._2_OCP.Solucao_extensao2;

public static class ContaExtensions
{
    public static void CalcularRendimentoContaCorrente(this Conta conta, decimal taxaRendimento)
    {
        conta.Saldo *= (1 + taxaRendimento / 2);
    }
}
