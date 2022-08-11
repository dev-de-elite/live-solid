using System.Data;
using System.Data.SqlClient;

namespace SOLID.Console._1_SRP.Solucao;

public class PedidoRepository
{
    public static void Salvar(Pedido pedido)
    {
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
    }
}
