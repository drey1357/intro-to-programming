namespace Banking.Domain
{
    public class BankAccount
    {
        private decimal _balance = 5000; // "fields" "class level variables"
        public void Deposit(decimal amountToDeposit)
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
