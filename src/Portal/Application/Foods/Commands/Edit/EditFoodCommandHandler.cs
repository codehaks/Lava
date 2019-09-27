using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.Foods.Commands.Edit
{
    public class EditFoodCommandHandler : IRequestHandler<EditFoodCommand, EditFoodCommandResult>
    {
        public Task<EditFoodCommandResult> Handle(EditFoodCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
