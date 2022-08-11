using SOLID.Console._5_DIP.Solucao.Interfaces;
using System.Net.Mail;

namespace SOLID.Console._5_DIP.Solucao
{
    public class EmailService : IEmailService
    {
        public async Task EnviarEmailPedidoRealizado(int numeroPedido, string emailDestinatario)
        {
            var email = new MailMessage("vendas@devdeelite.com.br", emailDestinatario);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            email.Subject = $"Pedido nº. {numeroPedido}";
            email.Body = "Seu pedido foi realizado com sucesso!";
            await client.SendMailAsync(email);
        }
    }
}
