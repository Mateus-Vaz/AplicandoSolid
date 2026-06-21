using PrincipioSolid.Interfaces;
using PrincipioSolid.Models;
using PrincipioSolid.Services;

namespace PrincipioSolid.Services
{
    // esta classe tem uma única responsabilidade — ORQUESTRAR o fluxo do pedido, delegando cada etapa ao especialista correto.
    public class ProcessadorPedido
    {
        private readonly IPedidoRepository _repository;
        private readonly INotificacaoService _notificacao;
        private readonly PedidoValidator _validator;
        private readonly PedidoCalculator _calculator;

        public ProcessadorPedido(
            IPedidoRepository repository,
            INotificacaoService notificacao,
            PedidoValidator validator,
            PedidoCalculator calculator)
        {
            _repository = repository;
            _notificacao = notificacao;
            _validator = validator;
            _calculator = calculator;
        }

        public void Processar(Pedido pedido)
        {
            _validator.Validar(pedido);
            _calculator.AplicarDescontos(pedido);
            _repository.Salvar(pedido);
            _notificacao.EnviarConfirmacao(pedido);
        }
    }
}
