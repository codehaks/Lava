using Portal.Common.Values;
using Portal.Core.Contracts;
using Portal.Core.Enums;
using Portal.Domain.Common;
using Portal.Domain.Entities.OrderAggregate.Specs;
using System;
using System.Text;

namespace Portal.Domain.Entities
{
    public class Order : ITimeCreated
    {
        private Order()
        {

        }
        public Order(string userId, int foodId, byte count, Money unitPrice)
        {
            if (count <= 0)
            {
                throw new Exception("Order is empty");
            }
            if (count > 10)
            {
                throw new Exception("Too much food");
            }
            UserId = userId;
            FoodId = foodId;
            Count = count;
            UnitPrice = unitPrice;
            TimeCreated = DateTime.Now;
        }
        public int Id { get; set; }
        public string UserId { get; }

        public int FoodId { get; }
        public int Count { get; private set; }

        public Money UnitPrice { get; }

        public Money TotalPrice
        {
            get
            {
                return new Money(Count * UnitPrice.Amount);
            }

           }

        public OrderState State { get; set; }

        public DateTime TimeCreated { get; set; }

        public ISpecification<Order> CanBeCanceledBeforeCooking = new CanBeCanceledBeforeCooking();
        public void Cancel()
        {
            if (CanBeCanceledBeforeCooking.IsSatisfiedBy(this))
            {
                // cancel order
            }
            else
            {
                throw new Exception("Can not be canceled : Cooking started!");
            }
        }

    }
}
