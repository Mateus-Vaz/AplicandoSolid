using PrincipioSolid.Models;

namespace PrincipioSolid.Services
{
    // esta classe tem uma única responsabilidade — validar os dados de entrada de um pedido.
    public class PedidoValidator
    {
        public void Validar(Pedido pedido)
        {
            if (pedido.ValorTotal <= 0)
                throw new ArgumentException("Valor do pedido inválido.");

            if (string.IsNullOrWhiteSpace(pedido.Cliente))
                throw new ArgumentException("Nome do cliente é obrigatório.");

            if (string.IsNullOrWhiteSpace(pedido.EmailCliente))
                throw new ArgumentException("E-mail do cliente é obrigatório.");
        }
    }
}
