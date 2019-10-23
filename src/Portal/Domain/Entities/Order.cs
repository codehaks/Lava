using Portal.Common.Kernel;
using Portal.Common.Values;
using Portal.Core.Contracts;
using Portal.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    //public class FoodCount:ValueObject
    //{
    //    private FoodCount()
    //    {

    //    }
    //    public FoodCount(byte value)
    //    {
    //        if (value > 0)
    //        {
    //            throw new Exception("Too much food!");
    //        }
    //        Value = value;
    //    }
    //    public byte Value { get; }

    //    protected override IEnumerable<object> GetAtomicValues()
    //    {
    //        yield return Value;
    //    }
    //}
    public class Order : ITimeCreated
    {
        private Order()
        {

        }
        public Order(string userId, int foodId, byte count, Money unitPrice)
        {
            if (count<=0 )
            {
                throw new Exception("Order is empty");
            }
            if (count>10)
            {
                throw new Exception("Too much food");
            }
            UserId = userId;
            FoodId = foodId;
            Count = count;
            UnitPrice = unitPrice;
        }
        public int Id { get; set; }
        public string UserId { get; }

        public int FoodId { get; }
        public int Count { get; private set; }

        public Money UnitPrice { get; }
        public Money TotalPrice
        {
            get
            { return new Money(Count * UnitPrice.Amount); }
        }

        public OrderState State { get; set; }

        public DateTime TimeCreated { get; set; }

    }
}
