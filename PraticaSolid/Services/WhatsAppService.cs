using PrincipioSolid.Interfaces;
using PrincipioSolid.Models;

namespace PrincipioSolid.Services
{
    // O - Open/Closed: nova forma de notificação adicionada SEM modificar o ProcessadorPedido, EmailService ou qualquer outro arquivo existente.
    public class WhatsAppService : INotificacaoService
    {
        public void EnviarConfirmacao(Pedido pedido)
        {
            Console.WriteLine($"[WHATSAPP] Enviando para {pedido.Telefone}: " +
                              $"Olá {pedido.Cliente}, seu pedido foi confirmado! " +
                              $"Valor final: R${pedido.ValorTotal}");
        }
    }
}
