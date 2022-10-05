using SOLID.Console._5_DIP.Solucao.Interfaces;

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
        if (!pedido.Validar())
            return default;

        _pedidoRepository.Salvar(pedido);

        _emailService.EnviarEmailPedidoRealizado(pedido.Id, pedido.Cliente.Email.Endereco);

        return true;
    }
}
