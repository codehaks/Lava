using Portal.Core.Contracts;
using Portal.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class Payment : ITimeCreated
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public PaymentState State { get; set; }
        public PaymentType Type { get; set; }
        public DateTime TimeCreated { get; set; }
    }
}
