using entregas;
using System;

Cliente clientePaulo = new Cliente();
clientePaulo.nome = "Paulo Latejando";
clientePaulo.cpf = "129168113-79";
clientePaulo.email = "paulado@gmail.com";

clientePaulo.endereco= new Endereco();
clientePaulo.endereco.rua = "Castro";
clientePaulo.endereco.numero = 54;
clientePaulo.endereco.bairro = "Lalalandia";
clientePaulo.endereco.cidade = "Piracicaba";
clientePaulo.endereco.cep = "21171-998";

Pedido pedidoPaulo = new Pedido();
pedidoPaulo.numero_Pedido = 10101;
pedidoPaulo.cliente.nome = clientePaulo.nome;

pedidoPaulo.item = new ItemPedido();
//pedidoPaulo.item.numero_Pedido = pedidoPaulo.numero_Pedido;
//pedidoPaulo.item.produto1.codigo_Produto = 1100;
//pedidoPaulo.item.quantidade = 1;

pedidoPaulo.item.produto1 = new Produto();
pedidoPaulo.item.produto1.Descricao = "Strogonoff de Frango";
pedidoPaulo.item.produto1.valor_Unitario = 29.90;
pedidoPaulo.item.produto1.quantidade = 1;
pedidoPaulo.item.produto1.codigo_Produto = 9998;

pedidoPaulo.total_Pedido = 29.90f;