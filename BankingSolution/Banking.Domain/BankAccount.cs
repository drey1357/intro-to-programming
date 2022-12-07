namespace Banking.Domain;

public enum BankAccountType { Standard, Gold }

public class BankAccount
{
    public BankAccountType AccountType = BankAccountType.Standard;
    private decimal _balance = 5000; // "fields" "class level variables"
    public void Deposit(decimal amountToDeposit)
    {
        decimal bonus = AccountType == BankAccountType.Standard
            ? 0
            : amountToDeposit * .10M;

        _balance += amountToDeposit + bonus;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public decimal Withdraw(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            throw new OverdraftException();
        }
        else
        {
            _balance -= amountToWithdraw;
        }
        return _balance;
    }
}

