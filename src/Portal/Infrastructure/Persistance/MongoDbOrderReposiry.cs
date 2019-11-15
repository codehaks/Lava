using Portal.Domain.Entities;
using Portal.Domain.Model.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infrastructure.Persistance.Data
{
    class MongoDbOrderReposiry : IOrderRepository
    {
        public Task<int> Create(Order order)
        {
            throw new NotImplementedException();
        }

        public Order FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
