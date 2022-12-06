

namespace Banking.UnitTests
{
    public class MakingWithdrawals
    {
        [Theory]
        [InlineData(50)]
        [InlineData(1000)]
        public void MakingWithdrawalReducesBalance(decimal amountToWithdraw)
        {
            //given
            var account = new BankAccount();
            var openingBalance = account.GetBalance();

            //when
            account.Withdraw(amountToWithdraw);

            //then
            Assert.Equal(openingBalance-amountToWithdraw, account.GetBalance());
        }
    }
}
