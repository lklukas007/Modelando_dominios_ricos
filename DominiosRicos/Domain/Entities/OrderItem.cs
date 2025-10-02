namespace Domain.Entities
{
    using Domain.ValueObjects;  // Para o tipo Money
    using Domain.Exceptions;    // Para a DomainException

    public class OrderItem
    {
        public string ProductName { get; private set; }
        public Money Price { get; private set; }
        public int Quantity { get; private set; }

        public Money TotalAmount => Price * Quantity;

        public OrderItem(string productName, Money price, int quantity)
        {
            if (quantity <= 0)
                throw new DomainException("Quantity must be greater than zero.");

            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }
    }
}
