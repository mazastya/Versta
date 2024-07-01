using Microsoft.EntityFrameworkCore;
using Versta.DataAccess;
using Versta.Models;
using Versta.Repositories.Interfaces;

namespace Versta.Repositories;

public class OrderRepository(ApplicationDbContext context) : IOrderRepository
{
    public async Task AddOrder(Order order)
    {
        context.Order.Add(order);
        await context.SaveChangesAsync();
    }

    public async void Update(Order order)
    {
        context.Order.Update(order);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Order>> GetAll()
    {
        return await context.Order.ToListAsync();
    }
}
