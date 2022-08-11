namespace SOLID.Console._5_DIP.Solucao.Interfaces;

public interface IEmailService
{
    Task EnviarEmailPedidoRealizado(int numeroPedido, string emailDestinatario);
}
