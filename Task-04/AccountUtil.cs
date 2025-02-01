namespace Task_04;

public static class AccountUtil
{
    public static void Display<T>(List<T> accounts) where T : Account
    {
        var accountType = typeof(T).Name;
        Console.WriteLine($"\n=== {accountType}s ==========================================");
        foreach (var acc in accounts)
        {
            Console.WriteLine(acc);
        }
    }

    public static void Deposit<T>(List<T> accounts, double amount) where T : Account
    {
        var accountType = typeof(T).Name;
        Console.WriteLine($"\n=== Depositing to {accountType}s =================================");
        foreach (var acc in accounts)
        {
            if (acc.Deposit(amount))
            {
                if (acc is TrustAccount && amount >= 5000)
                    Console.WriteLine($"Deposited {amount} (plus $50 bonus) to {acc}");
                else
                    Console.WriteLine($"Deposited {amount} to {acc}");
            }
            else
                Console.WriteLine($"Failed Deposit of {amount} to {acc}");
        }
    }

    public static void Withdraw<T>(List<T> accounts, double amount) where T : Account
    {
        var accountType = typeof(T).Name;
        Console.WriteLine($"\n=== Withdrawing from {accountType}s ==============================");
        foreach (var acc in accounts)
        {
            if (acc.Withdraw(amount))
            {
                if (acc is CheckingAccount)
                    Console.WriteLine($"Withdrew {amount} (plus fee) from {acc}");
                else
                    Console.WriteLine($"Withdrew {amount} from {acc}");
            }
            else
            {
                if (acc is TrustAccount)
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc} - (20% limit or max withdrawals reached)");
                else if (acc is CheckingAccount)
                    Console.WriteLine($"Failed Withdrawal of {amount} (plus fee) from {acc}");
                else
                    Console.WriteLine($"Failed Withdrawal of {amount} from {acc}");
            }
        }
    }
}