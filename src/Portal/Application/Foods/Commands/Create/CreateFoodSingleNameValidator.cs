using MediatR;
using MediatR.Pipeline;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.Foods.Commands.Create
{
    public class CreateFoodSingleNameValidator : IPipelineBehavior<CreateFoodCommand, CreateFoodCommandResult>
    {
        private readonly PortalDbContext _db;

        public CreateFoodSingleNameValidator(PortalDbContext db)
        {
            _db = db;
        }

        public async Task<CreateFoodCommandResult> Handle(CreateFoodCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<CreateFoodCommandResult> next)
        {
          
            var any = _db.Foods.Any(f => f.Name.Trim() == request.Name.Trim());
            if (any)
            {
                throw new Exception("Food already exists!");
            }
            var response = await next();
            return response;
        }
        //public async Task<CreateFoodCommandResult> Handle(CreateFoodCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<CreateFoodCommandResult> next)
        //{
        //    var r = (CreateFoodCommand)request;

        //    //_db.Foods.Where(f=>f.Name.Trim()==request.)
        //    await Task.CompletedTask;
        //    return next();
        //}

        //public Task Process(CreateFoodCommand request, CreateFoodCommand response, CancellationToken cancellationToken)
        //{
        //    var any = _db.Foods.Any(f => f.Name.Trim() == request.Name.Trim());
        //    var result = new CreateFoodCommandResult
        //    {
        //        ValidationResult = new FluentValidation.Results.ValidationResult();
        //    };
        //    if (any)
        //    {

        //    }
        //}
    }
}
