using Portal.Common.Kernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Common.Values
{
    public class Money : ValueObject
    {
        private Money()
        {

        }
        public Money(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Money can not be less than zero");
            }

            Amount = amount;
        }

        public int Amount { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Amount;
        }
    }
}
