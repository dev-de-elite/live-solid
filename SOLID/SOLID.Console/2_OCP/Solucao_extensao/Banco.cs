using SOLID.Console._2_OCP.Solucao_extensao2;

namespace SOLID.Console._2_OCP.Solucao_extensao;

public class Banco
{
    public void Executar()
    {
        var conta = new Conta();
        conta.Saldo = 100;

        conta.CalcularRendimentoContaCorrente(10);
    }
}
