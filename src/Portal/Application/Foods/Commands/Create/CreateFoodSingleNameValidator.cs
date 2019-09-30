using MediatR;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.Foods.Commands.Create
{
    public class CreateFoodSingleNameValidator<CreateFoodCommand, CreateFoodCommandResult> :
        IPipelineBehavior<CreateFoodCommand, CreateFoodCommandResult>
    {
        private readonly PortalDbContext _db;

        public CreateFoodSingleNameValidator(PortalDbContext db)
        {
            _db = db;
        }
        public async Task<CreateFoodCommandResult> Handle(CreateFoodCommand request, CancellationToken cancellationToken, RequestHandlerDelegate<CreateFoodCommandResult> next)
        {
            var r = (CreateFoodCommand)request;
            
            //_db.Foods.Where(f=>f.Name.Trim()==request.)
            await Task.CompletedTask;
            return next();
        }
    }
}
