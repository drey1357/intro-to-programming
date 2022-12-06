namespace CSharpSyntax
{
    public class UnitTest1
    {
        [Fact] //Attributes
        public void TestingTheAdditionOperatorOnIntegers()
        {
            //Given (Arrange)
            int a = 10, b = 20, answer;
            //When (Act)
            answer = a + b; //"System Under Test"(SUT)
            //Then (Assert)
            Assert.Equal(30, answer);
        }

        [Theory]
        [InlineData(10,20,30)]
        [InlineData(2,3,5)]
        [InlineData(-5,11,6)]
        public void CanAddAnyTwoIntegers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }
    }
}