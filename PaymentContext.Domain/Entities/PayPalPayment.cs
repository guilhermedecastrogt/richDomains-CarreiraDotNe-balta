namespace PaymentContext.Domain.Entities;

public class PayPalPayment : Payment
{
    public PayPalPayment(Guid id, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid,
        string address, string document, string owner, string email, string transactionCode) : base(
        id, paidDate, expireDate, total, totalPaid, address, document, owner, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; set; }
}