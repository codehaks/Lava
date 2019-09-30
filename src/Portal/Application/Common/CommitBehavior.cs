using MediatR;
using MediatR.Pipeline;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portal.Application.Common
{
    public class CommitBehavior<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    {
        private readonly PortalDbContext _db;

        public CommitBehavior(PortalDbContext db)
        {
            _db = db;
        }

        //public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        //{
        //    var response =await next();
        //    await _db.SaveChangesAsync();
        //    return response;
        //}

        public async Task Process(TRequest request, TResponse response, CancellationToken cancellationToken)
        {
            await _db.SaveChangesAsync();
        }
    }
}
