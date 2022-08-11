namespace SOLID.Console._5_DIP.Solucao;

public class RealizarPedidoService
{
    private readonly IPedidoRepository _pedidoRepository;
    private readonly IEmailService _emailService;

    public RealizarPedidoService(IPedidoRepository pedidoRepository, IEmailService emailService)
    {
        _pedidoRepository = pedidoRepository;
        _emailService = emailService;
    }

    public bool Realizar(Pedido pedido)
    {
        if (pedido.Cliente.Email.Contains('@'))
            throw new ArgumentException("Email inválido");

        if (pedido.Cliente.Cpf.Length != 11)
            throw new ArgumentException("CPF inválido");

        _pedidoRepository.Salvar(pedido);

        _emailService.EnviarEmailPedidoRealizado(pedido.Id, pedido.Cliente.Email);

        return true;
    }
}
