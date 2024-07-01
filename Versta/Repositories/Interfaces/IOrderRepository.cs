using Versta.Models;

namespace Versta.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAll();
        Task AddOrder(Order order);
        Task<Order> GetById(int id);
    }
}
