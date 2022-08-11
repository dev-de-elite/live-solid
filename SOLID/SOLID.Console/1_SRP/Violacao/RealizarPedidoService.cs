using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID.Console._1_SRP.Violacao;

public class RealizarPedidoService
{
    public async Task<bool> Realizar(Pedido pedido)
    {
        if (pedido.Cliente.Email.Contains('@'))
            throw new ArgumentException("Email inválido");

        if (pedido.Cliente.Cpf.Length != 11)
            throw new ArgumentException("CPF inválido");

        var command = new SqlCommand
        {
            CommandType = CommandType.Text,
            CommandText = "INSERT INTO PEDIDO (DATAREALIZADO, CLIENTEID) VALUES (@dataRealizado, @clienteId))"
        };

        command.Parameters.AddWithValue("dataRealizado", pedido.DataRealizado);
        command.Parameters.AddWithValue("clienteId", pedido.Cliente.Id);

        using var sqlConnection = new SqlConnection();
        sqlConnection.ConnectionString = "MinhaConnectionString";
        command.Connection = sqlConnection;
        sqlConnection.Open();
        command.ExecuteNonQuery();

        var email = new MailMessage("vendas@devdeelite.com.br", pedido.Cliente.Email);
        var client = new SmtpClient
        {
            Port = 25,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Host = "smtp.google.com"
        };

        email.Subject = $"Pedido nº. {pedido.Id}";
        email.Body = "Seu pedido foi realizado com sucesso!";
        await client.SendMailAsync(email);

        return true;
    }
}
