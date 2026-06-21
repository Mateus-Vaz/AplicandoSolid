using PrincipioSolid.Interfaces;
using PrincipioSolid.Models;

namespace PrincipioSolid.Services
{
    // S - Single Responsibility: responsável apenas por enviar notificação via e-mail.
    // O - Open/Closed: é uma extensão de INotificacaoService. por que se exemplo q amanhã, se precisarmos de WhatsApp, criamos WhatsAppService sem tocar em nenhum código existente.
    public class EmailService : INotificacaoService
    {
        public void EnviarConfirmacao(Pedido pedido)
        {
            Console.WriteLine($"[E-MAIL] Enviando para {pedido.EmailCliente}: " +
                              $"Seu pedido foi processado com sucesso! " +
                              $"Valor final: R${pedido.ValorTotal}");
        }
    }
}
