using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Foods.Models;
using Portal.Application.Foods.Queries;

namespace Portal.Web
{
    public class OrderModel : PageModel
    {
        private readonly IMediator _mediator;

        public OrderModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        public FoodInfo Food { get; set; }

        [BindProperty]
        public int FoodCount { get; set; }

        public async Task<IActionResult> OnGet(int foodId)
        {
            var food=await _mediator.Send(new GetFoodQuery
            {
                FoodId = foodId
            });

            Food = food.Food;

            FoodCount = 1;

            return Page();
        }

        //public async Task<IActionResult> OnPost()
        //{

        //}
    }
}