using MediatR;
using MediatR.Pipeline;
using Portal.Application.Common;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.Foods.Commands.Create
{
    public class CreateFoodSingleNameValidator :
        IPipelineBehavior<CreateFoodCommand, OperationResult<CreateFoodCommandResult>>
    {
        private readonly PortalDbContext _db;

        public CreateFoodSingleNameValidator(PortalDbContext db)
        {
            _db = db;
        }

        public async Task<OperationResult<CreateFoodCommandResult>> Handle(CreateFoodCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<OperationResult<CreateFoodCommandResult>> next)
        {

            var any = _db.Foods.Any(f => f.Name.Trim() == request.Name.Trim());
            if (any)
            {

                var result = OperationResult<CreateFoodCommandResult>.BuildFailure("Food name already exists");

                return result;
            }
            var response = await next();
            return response;
        }

    }
}
