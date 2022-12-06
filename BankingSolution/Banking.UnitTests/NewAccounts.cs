

using Banking.Domain;

namespace Banking.UnitTests
{
    public class NewAccounts
    {
        [Fact]
        public void HaveTheCorrectOpeningBalance()
        {
            //write the code you wish you had
            //given
            var account = new BankAccount();
            //when
            decimal balance = account.GetBalance();
            //then
            Assert.Equal(5000M, balance);
        }
    }
}
