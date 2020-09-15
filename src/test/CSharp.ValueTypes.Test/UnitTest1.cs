using System;
using Xunit;

namespace CSharp.ValueTypes.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var intMaxValue = int.MaxValue;

            Assert.Equal(2147483647, intMaxValue);
        }

    }
}
