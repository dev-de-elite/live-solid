namespace SOLID.Console._4_ISP.Solucao.Interfaces;

public interface ICadastroPedido : ICadastro, IValidacao
{
    void EnviarEmailPedido();
}
