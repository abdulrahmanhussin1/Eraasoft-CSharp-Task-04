namespace Task_04;

public class CheckingAccount : Account 
{
    private const double WithdrawalFee = 1.50;

    public CheckingAccount(string Name = "Unnamed Checking Account", 
        double Balance = 0.0) : base(Name, Balance)
    {
    }

    public override bool Withdraw(double amount)
    {
        amount += WithdrawalFee;
        return base.Withdraw(amount);
    }

    public override string ToString()
    {
        return $"[Checking Account: {Name}: ${Balance:F2}]";
    }
}