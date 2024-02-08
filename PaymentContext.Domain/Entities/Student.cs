﻿using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class Student
{
    private IList<Subscription> _subscriptions;
    public Student(Name name, Document document, Email email)
    {
        Name = name;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>();
    }

    public Guid Id { get; set; }
    public Name Name { get; set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public string Address { get; private set; }
    
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
    
    public void AddSubscription(Subscription subscription)
    {
        foreach (var sub in Subscriptions)
        {
            sub.Inactivate();
        }
        _subscriptions.Add(subscription);
    }
}