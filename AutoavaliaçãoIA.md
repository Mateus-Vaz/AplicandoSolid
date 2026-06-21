A i.a me ajudou na estrutura das pastas para desenvolver conforme os principios do Solid abaixo a resposta dela:

Aqui está a refatoração completa, Mateus! A organização de pastas conforme os princípios do SOLID. Veja o que foi feito:

Estrutura de pastas
AulaSolid/
├── Models/
│   └── Pedido.cs
├── Interfaces/
│   ├── IPedidoRepository.cs
│   └── INotificacaoService.cs
├── Repositories/
│   └── PedidoRepository.cs
├── Services/
│   ├── PedidoValidator.cs
│   ├── PedidoCalculator.cs
│   ├── EmailService.cs
│   ├── WhatsAppService.cs
│   └── ProcessadorPedido.cs
└── Program.cs
