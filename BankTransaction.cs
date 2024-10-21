using System;

public class BankTransaction
{
    public DateTime TransactionTime { get; }

    public double Amount { get; } 

    public BankTransaction(double amount)
    {
        TransactionTime = DateTime.Now;
        Amount = amount;

    }
}

