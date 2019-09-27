using FluentValidation.Results;
using Portal.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Application.Foods.Commands.Edit
{
    public class EditFoodCommandResult : CommandResult, IValidationResult
    {
        public ValidationResult ValidationResult { get; set; }
    }
}
