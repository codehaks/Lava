using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Foods.Models;
using Portal.Application.Foods.Queries;
using Portal.Application.OrderApplication.Commands;

namespace Portal.Web
{
    public class OrderModel : PageModel
    {
        private readonly IMediator _mediator;

        public OrderModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        [BindProperty]
        public FoodInfo Food { get; set; }

        [BindProperty]
        public byte FoodCount { get; set; }

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

        public async Task<IActionResult> OnPost()
        {
           var result= await _mediator.Send(new CreateOrderCommand{
                Count=FoodCount,
                FoodId=Food.Id,
                UnitPrice=Food.Price,
                UserId="1"
            });

            return RedirectToPage("/index");
        }
    }
}