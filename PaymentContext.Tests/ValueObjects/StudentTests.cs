using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void ShouldReturnErrorWhenHadActiveSubscription()
    {
        var name = new Name("Bruce", "Wayne");
        var document = new Document("35111507799", EDocumentType.CPF);
        var email = new Email("batman@dc.com");
        var address = new Address("Rua 1", "1234", "Bairro Legal", "Gotham", "SP", "BR", "13400000");
        var student = new Student(name, document, email);
        var subscription = new Subscription(null);
        var payment = new PayPalPayment("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Wayne Corp", document, address, email);
        
        subscription.AddPayment(payment);
        student.AddSubscription(subscription);
        student.AddSubscription(subscription);
        
    }
    
    [TestMethod]
    public void ShouldReturnErrorWhenHadSubscriptionHasNoPayment()
    {
        var name = new Name("Bruce", "Wayne");
        var document = new Document("35111507799", EDocumentType.CPF);
        var email = new Email("batman@dc.com");
        var student = new Student(name, document, email);
    }
    
    
}