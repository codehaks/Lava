using Portal.Common.Values;
using Portal.Core.Enums;
using System;

namespace Portal.Domain.Entities
{
    public class OrderSnapshot
    {
        public OrderSnapshot(int id, string userId, int foodId, int count, Money unitPrice)
        {
            Id = id;
            UserId = userId;
            FoodId = foodId;
            Count = count;
            UnitPrice = unitPrice;
            //...
        }

        public int Id { get; }
        public string UserId { get; }

        public int FoodId { get; }
        public int Count { get; }

        public Money UnitPrice { get; }

        public Money TotalPrice
        {
            get
            {
                return new Money(Count * UnitPrice.Amount);
            }

        }

        public OrderState State { get; }

        public DateTime TimeCreated { get; }

        public bool IsPremiumUser { get; }

        public bool CanBeCanceled { get; }
    }
}