

using Banking.Domain;

namespace Banking.UnitTests
{
    public class MakingDeposits
    {
        [Theory]
        [InlineData(100)]
        [InlineData(50)]
        public void MakingDepositsIncreasesBalance(decimal amountToDeposit)
        {
            //given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
     
            //when
            account.Deposit(amountToDeposit);
            //then
            Assert.Equal(amountToDeposit + openingBalance,
                account.GetBalance());
        }
    }
}
