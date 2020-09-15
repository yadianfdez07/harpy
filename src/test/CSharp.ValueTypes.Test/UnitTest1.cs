using System;
using Xunit;

namespace CSharp.ValueTypes.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestIntMaxValue()
        {
            var intMaxValue = int.MaxValue;

            Assert.Equal(2147483647, intMaxValue);
        }

        [Fact]
        public void TestIntMinValue()
        {
            //Given

            //When

            //Then
            Assert.Equal(-2147483648, int.MinValue);
        }

    }
}
