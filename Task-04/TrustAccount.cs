namespace Task_04;

public class TrustAccount : SavingsAccount
{
    private const double BonusThreshold = 5000.0;
    private const double BonusAmount = 50.0;
    private const double MaxWithdrawalPercent = 0.2;
    private const int MaxWithdrawals = 3;
    private int withdrawalsThisYear = 0;

    public TrustAccount(string Name = "Unnamed Trust Account", 
        double Balance = 0.0, 
        double InterestRate = 3.0) : base(Name, Balance, InterestRate)
    {
    }

    public override bool Deposit(double amount)
    {
        if (amount >= BonusThreshold)
            amount += BonusAmount;
        return base.Deposit(amount);
    }

    public override bool Withdraw(double amount)
    {
        if (withdrawalsThisYear >= MaxWithdrawals || 
            amount > Balance * MaxWithdrawalPercent)
            return false;

        if (base.Withdraw(amount))
        {
            withdrawalsThisYear++;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"[Trust Account: {Name}: ${Balance:F2}, Interest Rate: {InterestRate}%, Withdrawals: {withdrawalsThisYear}]";
    }
}