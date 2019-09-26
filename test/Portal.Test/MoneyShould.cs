using Portal.Common.Values;
using System;
using Xunit;

namespace Portal.Test
{
    public class MoneyShould
    {
        [Fact]
        public void ErrorLessThanZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
           {
               var money = new Money(-5);
           });
        }
    }
}
