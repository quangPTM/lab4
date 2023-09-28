public delegate void BalanceChanged(int newBalance);
public class Account
{
    private int balance;
    public event BalanceChanged balanceChanged;
    public Account(int initialBalance)
    {
        this.balance = initialBalance;
    }
    public int GetBalance()
    {
        return balance;
    }
    public void PerformTransaction(int amount)
    {
        balance += amount;

        if (balanceChanged != null)
        {
            balanceChanged(balance);
        }
    }
}


