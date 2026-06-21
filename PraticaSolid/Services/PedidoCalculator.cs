using PrincipioSolid.Models;

namespace PrincipioSolid.Services
{
    //esta classe tem uma única responsabilidade — aplicar as regras de negócio (cálculo de desconto) sobre o pedido.
    public class PedidoCalculator
    {
        public void AplicarDescontos(Pedido pedido)
        {
            if (pedido.ValorTotal > 1000)
            {
                pedido.ValorTotal -= 100; // Desconto VIP
                Console.WriteLine($"Desconto VIP aplicado! Novo valor: R${pedido.ValorTotal}");
            }
        }
    }
}
