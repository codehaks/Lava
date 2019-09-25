using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Foods;
using Portal.Web.Models;

namespace Portal.Web.Areas.User.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly IFoodService _foodService;
        public OrdersModel(IFoodService foodService)
        {
            _foodService = foodService;
        }
        public async Task<IActionResult> OnGet()
        {
            var foodList = await _foodService.GetAll();
            var vm = new UserOrderViewModel
            {
                FoodList = foodList.ToList(),
                UserId = "55656",
                UserName = User.Identity.Name
            };

            return Page();
        }
    }
}