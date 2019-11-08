using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Domain.Model.OrderAggregate
{
    public interface IOrderRepository
    {
        Order FindById(int id);
        Task<int> Create(Order order);
    }
}
