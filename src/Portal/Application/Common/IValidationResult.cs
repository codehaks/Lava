using FluentValidation.Results;

namespace Portal.Core.Common
{
    public interface IValidationResult
    {
        public ValidationResult ValidationResult { get; set; }
    }
}
