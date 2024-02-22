using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities;
public abstract class Payment : Entity
{
    protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address adress,Email email)
    {
        //Id = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
        PaidDate = paidDate;
        ExpireDate = expireDate;
        Total = total;
        TotalPaid = totalPaid;
        Payer = payer;
        Document = document;
        Address = adress;
        Email = email;
        
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsGreaterThan(0, Total, "Payment.Total", "Total not be 0")
            .IsGreaterOrEqualsThan(Total, TotalPaid, "Payment.Total", "Total paid not be 0")
        );
    }

    //public string Id { get; private set; }
    public DateTime PaidDate { get; private set; }
    public DateTime ExpireDate { get; private set; }
    public decimal Total { get; private set; }
    public decimal TotalPaid { get; private set; }
    public Address Address { get; private set; }
    public string Payer { get; set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
}