﻿using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities;

public class Student : Entity
{
    private IList<Subscription> _subscriptions;
    public Student(Name name, Document document, Email email)
    {
        Name = name;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>();

        AddNotifications(name, document, email);
    }

    public Name Name { get; set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public Address  Address { get; private set; }
    
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
    
    public void AddSubscription(Subscription subscription)
    {
        var hasSubscriptionActive = false;
        foreach (var sub in _subscriptions)
        {
            if (sub.Active)
                hasSubscriptionActive = true;
        }
        
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "You already have an active subscription")
            .IsGreaterThan(0, subscription.Payments.Count, "Student.Subscription.Payments", "This subscription has no payment")
        );
        
        // Other way
            //if(hasSubscriptionActive)
                //AddNotification("Student.Subscriptions", "You already have an active subscription");
    }
}