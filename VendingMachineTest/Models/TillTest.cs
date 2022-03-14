
using Xunit;
using VendingMachine;

namespace VendingMachineTest.Models
{
    public class TillTest
    {
        [Theory]
        [InlineData(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 9440)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0)]
        [InlineData(new int[] { 5, 5, 5 }, 40)]
        [InlineData(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 9440)]
        public void GetSaldoFromArrayTest(int[] array, int expected)
        {
            //Assign
            Till till = new Till();
            //Act
            int result = till.GetSaldoFromArray(array);

            //Assert
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 9440)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0)]
        [InlineData(new int[] { 5, 5, 5 }, 40)]
        [InlineData(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 9440)]
        public void GetRefillChangeTest(int[] array, int expected)
        {
            //Assign
            Till till = new Till();
            till.RefillChange(array);
            //Act
            int result = till.GetSaldo();

            //Assert
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 9440)]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0)]
        [InlineData(new int[] { 5, 5, 5 }, 40)]
        [InlineData(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, 9440)]
        public void GetSaldoTest(int[] array, int expected)
        {
            //Assign
            Till till = new Till(array);
            //Act
            int result = till.GetSaldo();

            //Assert
            Assert.Equal(expected, result);
        }
        [Theory]
       [InlineData(1888, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, new int[] { 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 })]
       [InlineData(110, new int[] { 0, 0, 0, 1, 0, 0, 1, 0, 0, 0 }, new int[] {  10,10,10, 9, 10, 10,9, 10, 10, 10 })]
       [InlineData(18880, new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 })]
       [InlineData(-5, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 })]
       [InlineData(188000, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 })]
        public void WithDrawTest(int withdraw, int[] expected, int[] expectedTill)
        {
            //Assign
            Till till = new Till(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });
            //Act
            int[] result = till.Withdraw(withdraw);

            //Assert
            Assert.Equal(expected, result);
            Assert.Equal(expectedTill, till.GetTill());
        }

    }
}
