namespace Domain.Entities
{
    using Domain.ValueObjects;
    using Domain.Exceptions;

    public class OrderItem
    {
        public string ProductName { get; private set; }
        public Money Price { get; private set; }
        public int Quantity { get; private set; }

        public Money TotalAmount => Price * Quantity;

        public OrderItem(string productName, Money price, int quantity)
        {
            if (quantity <= 0)
                throw new DomainException("A quantidade deve ser maior que zero.");

            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }
    }
}
