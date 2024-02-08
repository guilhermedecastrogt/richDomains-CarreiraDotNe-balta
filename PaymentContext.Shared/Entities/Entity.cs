﻿using Flunt.Notifications;

namespace PaymentContext.Shared.Entities;

public abstract class Entity : Notification
{
    protected Entity(Guid id)
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; private set; }
}