using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portal.Application.Foods;
using Portal.Application.Foods.Commands;
using Portal.Common.Enums;
using Portal.Common.Values;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Portal.Web.Areas.Admin.Pages.Foods
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IMediator _mediator;
        public CreateModel(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Range(0, int.MaxValue)]
        [Required]
        public int PriceAmount { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }

        [Required]
        public FoodType FoodType { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _mediator.Send(new CreateFoodCommand
            {
                Price = new Money(PriceAmount),
                Description = Description,
                FoodType = FoodType,
                Name = Name
            });


            return RedirectToPage("./index");
        }
    }
}