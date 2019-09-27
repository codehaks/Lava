using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Foods;
using Portal.Application.Foods.Models;
using Portal.Application.Foods.Queries;
using Portal.Common.Enums;

namespace Portal.Web.Areas.Admin.Pages.Foods
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly IMediator _mediator;
        public EditModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        public int Id { get; set; }
        public int PriceAmount { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }

        public async Task<IActionResult> OnGet(int id)
        {
            var queryResult = await _mediator.Send(new GetFoodQuery {
            FoodId=id});

            Id = queryResult.Food.Id;
            PriceAmount = queryResult.Food.Price.Amount;
            Name = queryResult.Food.Name;
            Description = queryResult.Food.Description;
            FoodType = queryResult.Food.FoodType;
            return Page();

        }

        public async Task<IActionResult> OnPost()
        {
            //await _foodService.Update(new FoodEditInfo()
            //{
            //    Id = Id,
            //    Name = Name,
            //    Price = new Common.Values.Money(PriceAmount),
            //    Description = Description,
            //    FoodType = FoodType
            //});

            return RedirectToPage("./Index");
        }

    }
}