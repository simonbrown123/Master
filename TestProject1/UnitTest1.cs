using System;
using Xunit;
using WebApplication1.Models;

namespace WebApplication.tests
{
    public class UnitTest1
    {
        private double valueOne = 10;
        private double valueTwo = 5;
        private double knownTotal = 15;

        [Fact]
        public void Test1()
        {
            Calculation calc = new Calculation();
            var totalValue = calc.AddTwoValues(valueOne, valueTwo);
            Assert.Equal(totalValue, knownTotal);
        }
    }
}
