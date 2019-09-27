using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Web.Controllers
{
    public class ValidatorController:Controller
    {
        private readonly  IList<IValidator<IRequest>> _validators;

        public ValidatorController(IList<IValidator<IRequest>> validators)
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
