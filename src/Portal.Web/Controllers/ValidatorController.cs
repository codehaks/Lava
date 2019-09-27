using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Portal.Application.Foods.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Web.Controllers
{
    public class ValidatorController:Controller
    {
        private readonly  IList<IValidator<CreateFoodCommand>> _validators;

        public ValidatorController(IList<IValidator<CreateFoodCommand>> validators)
        {
            _validators = validators;
        }

        [Route("api/val")]
        public IActionResult Index()
        {
            return Ok(_validators.Count());
        }

    }
}
