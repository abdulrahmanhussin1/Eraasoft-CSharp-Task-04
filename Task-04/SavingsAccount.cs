namespace Task_04;

public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount(string Name = "Unnamed Savings Account", 
        double Balance = 0.0, 
        double InterestRate = 3.0) : base(Name, Balance)
    {
        this.InterestRate = InterestRate;
    }

    public override bool Deposit(double amount)
    {
        amount += amount * (InterestRate / 100);
        return base.Deposit(amount);
    }

    public override string ToString()
    {
        return $"[Savings Account: {Name}: ${Balance:F2}, Interest Rate: {InterestRate}%]";
    }
}