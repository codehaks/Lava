using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class Coupan
    {
        public string Code { get; set; }

        public DateTime TimeStarts { get; set; }
        public DateTime TimeEnds { get; set; }

        public int Discount { get; set; }

        public int UsedCount { get; set; }
        public int TotalCount { get; set; }

        public int AvailableCount
        {
            get
            {
                return TotalCount - UsedCount;
            }
        }
    }
}
