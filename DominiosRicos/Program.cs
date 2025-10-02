using Application.Services;
using Domain.Entities;
using Domain.ValueObjects;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando um novo pedido
        var orderService = new OrderService();
        var order = orderService.CreateOrder("John Doe");

        // Adicionando itens ao pedido
        orderService.AddItemToOrder(order, "Produto A", 10.5m, 2);  // 2 unidades de Produto A, cada um custa 10.5
        orderService.AddItemToOrder(order, "Produto B", 15.0m, 1);  // 1 unidade de Produto B, custa 15.0

        // Confirmando o pedido
        orderService.ConfirmOrder(order);

        // Exibindo o total
        Console.WriteLine($"Pedido {order.Id} de {order.CustomerName} foi confirmado.");
        Console.WriteLine($"Valor total: {order.GetTotal()}");

        // Esperar o usuário pressionar uma tecla para encerrar
        Console.ReadLine();
    }
}
