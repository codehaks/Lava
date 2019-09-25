using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Foods;
using Portal.Application.Foods.Models;

namespace Portal.Web.Pages.Foods
{
    public class IndexModel : PageModel
    {
        private readonly IFoodService _foodService;

        public IndexModel(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public IList<FoodInfo> FoodList { get; set; }

        public async Task<IActionResult> OnGet()
        {
            FoodList = await _foodService.GetAll();
            return Page();
        }
    }
}