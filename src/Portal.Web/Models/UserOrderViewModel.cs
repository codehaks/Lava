using Portal.Application.Foods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Web.Models
{
    public class UserOrderViewModel
    {
        public IList<FoodInfo> FoodList { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
    }
}
