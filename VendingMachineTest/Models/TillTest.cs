
using Xunit;
using VendingMachine;

namespace VendingMachineTest.Models
{
    public class TillTest
    {
        [Theory]
        [InlineData(new int[]{ 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 },9440)]
        [InlineData(new int[]{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },0)]
        [InlineData(new int[]{ 5, 5, 5  },40)]
        [InlineData(new int[]{ 5, 5, 5 ,5,5,5,5,5,5,5,5,5,5,5,5,5 }, 9440)]
        public void GetSaldoFromArrayTest(int[] array,int expected )
        {
            //Assign
            Till till = new Till();
            //Act
            int result = till.GetSaldoFromArray(array);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
