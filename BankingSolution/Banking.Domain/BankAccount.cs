namespace Banking.Domain
{
    public class BankAccount
    {
        private decimal _balance = 5000; // "fields" "class level variables"
        public virtual void Deposit(decimal amountToDeposit) //virtual makes it overrideable
        {
            _balance += amountToDeposit;
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
}
