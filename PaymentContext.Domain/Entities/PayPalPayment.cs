using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class PayPalPayment : Payment
{
    public PayPalPayment(Guid id, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid,
        string payer, Address address, Document document, Email email, string transactionCode) : base(
        id, paidDate, expireDate, total, totalPaid, payer, address, document, email)
    {
        TransactionCode = transactionCode;
    }

    public string TransactionCode { get; set; }
}