using PrincipioSolid.Models;
using PrincipioSolid.Repositories;
using PrincipioSolid.Services;

// Montando o pedido
var pedido = new Pedido
{
    Cliente = "Mateus",
    ValorTotal = 1500,
    EmailCliente = "mateus@email.com",
    Telefone = "49999123456"
};

// Instanciando as dependências 
var validator   = new PedidoValidator();
var calculator  = new PedidoCalculator();
var repository  = new PedidoRepository();

// Exemplo 1: notificação por E-mail
Console.WriteLine("=== Processando com E-mail ===");
var emailService    = new EmailService();
var processadorEmail = new ProcessadorPedido(repository, emailService, validator, calculator);
processadorEmail.Processar(pedido);

// Exemplo 2: trocar para WhatsApp sem mudar ProcessadorPedido (princípio O)
Console.WriteLine("\n=== Processando com WhatsApp ===");

pedido.ValorTotal = 1500;

var whatsAppService     = new WhatsAppService();
var processadorWhatsApp = new ProcessadorPedido(repository, whatsAppService, validator, calculator);
processadorWhatsApp.Processar(pedido);
