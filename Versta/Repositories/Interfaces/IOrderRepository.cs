namespace Versta.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Models.Order>> GetAll();
        Task AddOrder(Models.Order order);
        void Update(Models.Order order);
    }
}
