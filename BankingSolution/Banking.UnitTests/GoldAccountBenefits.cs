using Banking.Domain;

namespace Banking.UnitTests
{
    public class GoldAccountBenefits
    {
        [Fact]
        public void GetBonusOnDeposit()
        {
            //given (context)
            var account = new GoldAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;
            var expectedBonus = 10M;
            //when
            account.Deposit(amountToDeposit);
            //then
            Assert.Equal(openingBalance + amountToDeposit + expectedBonus,
                account.GetBalance());
        }
    }
}