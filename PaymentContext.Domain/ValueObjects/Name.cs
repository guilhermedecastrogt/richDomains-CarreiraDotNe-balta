using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsLowerThan(FirstName, 3, "Name.FirstName", "Name must contain at least 3 characters")
            .IsLowerThan(LastName, 3, "Name.LastName", "Name must contain at least 3 characters")
            .IsGreaterThan(FirstName, 40, "Name.FirstName", "Name must contain at most 40 characters")
        );
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
}