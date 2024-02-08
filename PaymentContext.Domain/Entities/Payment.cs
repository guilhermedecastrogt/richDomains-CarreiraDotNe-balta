using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;
public abstract class Payment
{
    protected Payment(Guid id, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer ,string address, Document document, Email email)
    {
        Id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
        PaidDate = paidDate;
        ExpireDate = expireDate;
        Total = total;
        TotalPaid = totalPaid;
        Payer = payer;
        Address = address;
        Document = document;
        Email = email;
    }

    public string Id { get; private set; }
    public DateTime PaidDate { get; private set; }
    public DateTime ExpireDate { get; private set; }
    public decimal Total { get; private set; }
    public decimal TotalPaid { get; private set; }
    public string Address { get; private set; }
    public string Payer { get; set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
}