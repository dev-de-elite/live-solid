namespace SOLID.Console._1_SRP.Solucao;

public class RealizarPedidoService
{
    public async Task<bool> Realizar(Pedido pedido)
    {
        if (pedido.Cliente.Email.Contains('@'))
            throw new ArgumentException("Email inválido");

        if (pedido.Cliente.Cpf.Length != 11)
            throw new ArgumentException("CPF inválido");

        PedidoRepository.Salvar(pedido);

        await EmailService.EnviarEmailPedidoRealizado(pedido.Id, pedido.Cliente.Email);

        return true;
    }
}
