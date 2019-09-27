using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Portal.Application.Foods;
using Portal.Application.Foods.Models;
using Portal.Application.Foods.Queries;

namespace Portal.Web.Areas.Admin.Pages.Foods
{
    public class IndexModel : PageModel
    {
        private readonly IMediator _mediator;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(IMediator mediator, ILogger<IndexModel> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }


        public IList<FoodInfo> FoodList { get; set; }

        public async Task<IActionResult> OnGet()
        {
            _logger.LogInformation("Foods Index");
            FoodList = await _mediator.Send(new GetAllFoodsQuery());
            return Page();
        }
    }
}