namespace Domain.Entities
{
    using Domain.Enums;         // Para o enum OrderStatus
    using Domain.ValueObjects;  // Para o tipo Money
    using Domain.Exceptions;    // Para a DomainException
    using Domain.Interfaces;    // Para a interface IAggregateRoot
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Order : IAggregateRoot
    {
        private readonly List<OrderItem> _items = new List<OrderItem>();

        public Guid Id { get; private set; }
        public string? CustomerName { get; private set; }  // Tornando CustomerName anulável
        public OrderStatus Status { get; private set; }
        public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();
        public DateTime CreatedAt { get; private set; }

        private Order() { }

        public Order(string customerName)
        {
            if (string.IsNullOrWhiteSpace(customerName))
                throw new DomainException("Customer name cannot be empty.");

            CustomerName = customerName;
            Status = OrderStatus.Created;
            CreatedAt = DateTime.UtcNow;
        }

        public void AddItem(string productName, Money price, int quantity)
        {
            if (Status != OrderStatus.Created)
                throw new DomainException("You cannot add items to a confirmed order.");

            _items.Add(new OrderItem(productName, price, quantity));
        }

        public Money GetTotal()
        {
            return new Money(_items.Sum(item => item.TotalAmount.Amount));
        }

        public void Confirm()
        {
            if (_items.Count == 0)
                throw new DomainException("Cannot confirm an empty order.");

            Status = OrderStatus.Confirmed;
        }
    }
}
