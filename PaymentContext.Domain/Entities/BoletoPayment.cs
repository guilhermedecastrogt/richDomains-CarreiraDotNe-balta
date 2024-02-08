using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class BoletoPayment : Payment
{
    public BoletoPayment(Guid id, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid,
        string payer, string address, Document document, Email email, string barCode, string boletoNumber)
        : base(id, paidDate, expireDate, total, totalPaid, payer, address, document, email)
    {
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }


    public string BarCode { get; private set; }
    public string BoletoNumber { get; private set; }
}