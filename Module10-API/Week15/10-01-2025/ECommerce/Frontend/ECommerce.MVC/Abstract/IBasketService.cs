using ECommerce.MVC.Models;

namespace ECommerce.MVC.Abstract
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasketAsync(string applicationUserId);
        Task AddToBasketAsync(BasketItemModel basketItemModel);
        Task RemoveFromBasketAsync(int basketItemId);
        Task<string> ClearBasketAsync(string applicationUserId);
        Task<string> ChangeQuantityAsync(int basketItemId, int quantity);
        Task<bool> CreateBasketAsync(BasketModel basketModel);
    }
}
