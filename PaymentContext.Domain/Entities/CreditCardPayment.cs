using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class CreditCardPayment : Payment
{
    public CreditCardPayment(Guid id, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid,
        string payer, string address, Document document, Email email, string cardHolderName, string cardNumber,
        string lastTransactionNumber) : base(id, paidDate, expireDate, total, totalPaid, payer, address, document, email)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTransactionNumber = lastTransactionNumber;
    }


    public string CardHolderName { get; private set; }
    public string CardNumber { get; private set; }
    public string LastTransactionNumber { get; private set; }
}