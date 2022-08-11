using SOLID.Console._4_ISP.Solucao.Interfaces;

namespace SOLID.Console._4_ISP.Solucao;

public class CadastroPedido : ICadastroPedido
{
    public void ValidarDados()
    {
        // Validar dados do pedido
    }

    public void Salvar()
    {
        // Insert na tabela Pedido
    }

    public void EnviarEmailPedido()
    {
        // Enviar e-mail para o cliente
    }
}
