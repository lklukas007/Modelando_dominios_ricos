namespace Domain.ValueObjects
{
    using Domain.Exceptions;  // Para a DomainException

    public class Money
    {
        public decimal Amount { get; private set; }
        public string Currency { get; private set; }

        public Money(decimal amount, string currency = "USD")
        {
            if (amount < 0)
                throw new DomainException("Amount cannot be negative.");

            Amount = amount;
            Currency = currency;
        }

        public static Money operator +(Money a, Money b)
        {
            if (a.Currency != b.Currency)
                throw new DomainException("Cannot add amounts with different currencies.");

            return new Money(a.Amount + b.Amount, a.Currency);
        }

        public static Money operator *(Money a, int quantity)
        {
            return new Money(a.Amount * quantity, a.Currency);
        }

        public override string ToString() => $"{Amount} {Currency}";
    }
}
