namespace Src;

public class SimpleBankSystemSolution
{
    private readonly long[] _balance;

    public SimpleBankSystemSolution(long[] balance)
    {
        _balance = balance;
    }

    public bool Transfer(int account1, int account2, long money)
    {
        if (!IsValid(account1) || !IsValid(account2))
            return false;

        var i = account1 - 1;
        var j = account2 - 1;

        if (_balance[i] < money)
            return false;

        _balance[i] -= money;
        _balance[j] += money;

        return true;
    }

    public bool Deposit(int account, long money)
    {
        if (!IsValid(account))
            return false;

        _balance[account - 1] += money;

        return true;
    }

    public bool Withdraw(int account, long money)
    {
        if (!IsValid(account))
            return false;

        var i = account - 1;

        if (_balance[i] < money)
            return false;

        _balance[i] -= money;

        return true;
    }

    private bool IsValid(int account) => account >= 1 && account <= _balance.Length;
}
