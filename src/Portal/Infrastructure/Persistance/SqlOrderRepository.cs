using Portal.Domain.Entities;
using Portal.Domain.Model.OrderAggregate;
using Portal.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infrastructure.Repository
{
    public class SqlOrderRepository : IOrderRepository
    {
        private readonly PortalDbContext _db;

        public SqlOrderRepository(PortalDbContext db)
        {
            _db = db;
        }

        public async Task<int> Create(Order order)
        {
            var result=await _db.Orders.AddAsync(order);
            return result.Entity.Id;
        }

        public Order FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
