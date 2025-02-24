using ECommerce.MVC.Abstract;
using ECommerce.MVC.ComplexTypes;
using ECommerce.MVC.Models;
using System.Reflection;
using System.Text.Json;

namespace ECommerce.MVC.Services
{
    public class OrderService : BaseService, IOrderService
    {
        public OrderService(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, httpContextAccessor)
        {
        }

        public async Task AddAsync(OrderModel model)
        {
            var client = GetHttpClient();
            var response = await client.PostAsJsonAsync("orders",model);
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<OrderModel>>(jsonString, _jsonSerializerOptions);
            if(result?.Errors != null)
            {
                Console.WriteLine(string.Join(", ",result.Errors));
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<OrderModel> GetAsync(int id)
        {
            var client = GetHttpClient();
            var response = await client.GetAsync($"orders/{id}");
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<OrderModel>>(jsonString, _jsonSerializerOptions);
            if (result?.Errors != null)
            {
                Console.WriteLine(string.Join(", ", result.Errors));
                return null;
            }
            return result.Data;
        }

        public async Task<IEnumerable<OrderModel>> GetByDateRangeAsync(DateTime startDate, DateTime endDate, string userId)
        {
            var client = GetHttpClient();
            var response = 
                await client.GetAsync($"orders/daterange?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}");
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<OrderModel>>>(jsonString, _jsonSerializerOptions);
            if (result?.Errors != null)
            {
                Console.WriteLine(string.Join(", ", result.Errors));
                return null;
            }
            var orders=  result.Data;
            IEnumerable<OrderModel> ordersOfUser =
                orders
                .Where(x => x.ApplicationUserId == userId)
                .ToList();
            return ordersOfUser;
        }

        public async Task<IEnumerable<OrderModel>> GetByStatusAsync(OrderStatus status, string? userId = null)
        {
            var client = GetHttpClient();
            var response =
                await client.GetAsync($"orders/user/{userId}");
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<OrderModel>>>(jsonString, _jsonSerializerOptions);
            if (result?.Errors != null)
            {
                Console.WriteLine(string.Join(", ", result.Errors));
                return null;
            }
            var ordersOfUser =  result?.Data;
            IEnumerable<OrderModel> ordersOfUserByStatus =
                ordersOfUser
                .Where(x => x.OrderStatus == status)
                .ToList();
            return ordersOfUserByStatus;
        }

        public async Task<IEnumerable<OrderModel>> GetByUserAsync(string userId)
        {
            var client = GetHttpClient();
            var response =
                await client.GetAsync($"orders/user/{userId}");
            var jsonString = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<ResponseModel<IEnumerable<OrderModel>>>(jsonString, _jsonSerializerOptions);
            if (result?.Errors != null)
            {
                Console.WriteLine(string.Join(", ", result.Errors));
                return null;
            }
            return result.Data;
        }

        public Task UpdateAsync(OrderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
