namespace Task_04;

public class Account
{
    protected string Name { get; set; }
    protected double Balance { get; set; }

    public Account(string Name = "Unnamed Account", double Balance = 0.0)
    {
        this.Name = Name;
        this.Balance = Balance;
    }

    public virtual bool Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            return true;
        }
        return false;
    }

    public virtual bool Withdraw(double amount)
    {
        if (Balance - amount >= 0)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
    
    public override string ToString()
    {
        return $"[Account: {Name}: ${Balance:F2}]";
    }

    public static Account operator +(Account lhs, Account rhs)
    {
        return new Account("Sum Account", lhs.Balance + rhs.Balance);
    }
}