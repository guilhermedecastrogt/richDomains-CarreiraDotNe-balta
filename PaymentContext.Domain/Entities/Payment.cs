using PaymentContext.Domain.Entities;
namespace PaymentContext.Domain.Entities;
public abstract class Payment
{
    protected Payment(Guid id, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer ,string address, string document, string email)
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
    public string Document { get; private set; }
    public string Owner { get; private set; }
    public string Email { get; private set; }
}