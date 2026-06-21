using PrincipioSolid.Interfaces;
using PrincipioSolid.Models;

namespace PrincipioSolid.Repositories
{
    // S - Single Responsibility: responsável apenas por persistir o pedido no banco.
    public class PedidoRepository : IPedidoRepository
    {
        public void Salvar(Pedido pedido)
        {
            // Simulação de persistência no banco de dados
            Console.WriteLine($"[BANCO DE DADOS] Salvando pedido de {pedido.Cliente} " +
                              $"no valor de R${pedido.ValorTotal}...");
        }
    }
}
