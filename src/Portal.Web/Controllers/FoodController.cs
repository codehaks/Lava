using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portal.Application.Foods.Commands;
using Portal.Application.Foods.Models;
using Portal.Web.Models;

namespace Portal.Web.Controllers
{
    public class FoodController : Controller
    {
        private readonly IMediator _mediator;

        public FoodController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("api/food/create")]
        public async Task<IActionResult> Create(FoodAddModel model)
        {

            var result = await _mediator.Send(new CreateFoodCommand
            {
                Name = model.Name,
                Description = model.Description,
                FoodType = model.FoodType,
                Price = new Common.Values.Money(model.PriceAmount)
            });

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.ErrorMessage);
            }

        }
    }
}