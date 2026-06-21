namespace PrincipioSolid.Models
{
    public class Pedido
    {
        public string Cliente { get; set; } = string.Empty;
        public double ValorTotal { get; set; }
        public string EmailCliente { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
    }
}
