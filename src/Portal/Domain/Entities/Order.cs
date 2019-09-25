using Portal.Core.Contracts;
using Portal.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class Order:ITimeCreated
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int Count { get; set; }
        public int Amount { get; set; }

        public OrderState State { get; set; }

        public DateTime TimeCreated { get; set; }

    }
}
