using PrincipioSolid.Models;

namespace PrincipioSolid.Interfaces
{
    public interface INotificacaoService
    {
        void EnviarConfirmacao(Pedido pedido);
    }
}
