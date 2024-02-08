namespace PaymentContext.Domain.Entities;

public class BoletoPayment : Payment
{
    public BoletoPayment(Guid id,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string address,
        string document,
        string owner,
        string email,
        string barCode,
        string boletoNumber) : base(
        id,
        paidDate,
        expireDate,
        total,
        totalPaid,
        address,
        document,
        owner,
        email)
    {
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }

    public string BarCode { get; private set; }
    public string BoletoNumber { get; private set; }
}