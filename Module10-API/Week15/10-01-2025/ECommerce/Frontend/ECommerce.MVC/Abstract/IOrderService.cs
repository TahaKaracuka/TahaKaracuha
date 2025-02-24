using ECommerce.MVC.ComplexTypes;
using ECommerce.MVC.Models;

namespace ECommerce.MVC.Abstract
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderModel>> GetByUserAsync(string userId);
        Task<OrderModel> GetAsync(int id);
        Task AddAsync(OrderModel model);
        Task DeleteAsync(int id);
        Task UpdateAsync(OrderModel model);
        Task<IEnumerable<OrderModel>> GetByStatusAsync(OrderStatus status, string? userId=null);
        Task<IEnumerable<OrderModel>> GetByDateRangeAsync(DateTime startDate, DateTime endDate, string userId);

    }
}
