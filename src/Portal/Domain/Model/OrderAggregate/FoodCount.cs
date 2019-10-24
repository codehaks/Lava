using Portal.Common.Kernel;
using System;
using System.Collections.Generic;

namespace Portal.Domain.Entities
{
    public class FoodCount : ValueObject
    {
        private FoodCount()
        {

        }
        public FoodCount(byte value)
        {
            if (value > 0)
            {
                throw new Exception("Too much food!");
            }
            Value = value;
        }
        public byte Value { get; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}
