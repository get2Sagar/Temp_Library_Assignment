using System;
using Xunit;
using TempLibrary;

namespace TestTemp
{
    public class TestConversion
    {
        [Fact]
        public void TestScaleConv()
        {
            Temp obj = new Temp();
            double expected = 0;


            double actual = obj.FTC(32);
            Assert.Equal(expected, actual);

        }
    }
}
