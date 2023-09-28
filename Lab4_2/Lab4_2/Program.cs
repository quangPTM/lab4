using System.Security.Principal;
class Program
{
    static void Main(string[] args)
    {
        Account account = new Account(1000);

        account.balanceChanged += Account_BalanceChanged;

        Console.WriteLine("New Account Balance: $" + account.GetBalance());

        account.PerformTransaction(1000);
    }
    private static void Account_BalanceChanged(int newBalance)
    {
        Console.WriteLine("New Account Balance: $" + newBalance);
    }
}