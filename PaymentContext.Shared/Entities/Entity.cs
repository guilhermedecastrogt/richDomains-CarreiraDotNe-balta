
using Flunt.Notifications;

namespace PaymentContext.Shared.Entities;

public abstract class Entity : Notifiable<Notification>
{
    protected Entity(Guid id)
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }
}