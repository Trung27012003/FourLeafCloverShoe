using FourLeafCloverShoe.Share.Models;

namespace FourLeafCloverShoe.IServices
{
    public interface ICartItemItemService
    {
        public Task<bool> Add(CartItem obj);
        public Task<bool> AddMany(List<CartItem> lstobj);
        public Task<bool> Update(CartItem obj);
        public Task<bool> Delete(Guid Id);
        public Task<CartItem> GetById(Guid Id);
        public Task<List<CartItem>> Gets();
    }
}
