namespace Application.Services;

using Domain.Entities;
using Domain.ValueObjects;
using System;

public class OrderService
{
    public Order CreateOrder(string customerName)
    {
        var order = new Order(customerName);
        return order;
    }

    public void AddItemToOrder(Order order, string productName, decimal price, int quantity)
    {
        var priceObj = new Money(price);
        order.AddItem(productName, priceObj, quantity);
    }

    public void ConfirmOrder(Order order)
    {
        order.Confirm();
    }
}
