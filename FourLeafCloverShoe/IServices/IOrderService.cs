using FourLeafCloverShoe.Share.Models;

namespace FourLeafCloverShoe.IServices
{
    public interface IOrderService
    {
        public Task<bool> Add(OrderIterm obj);
        public Task<bool> AddMany(List<OrderIterm> lstobj);
        public Task<bool> Update(OrderIterm obj);
        public Task<bool> Delete(Guid Id);
        public Task<bool> DeleteMany(List<OrderIterm> lstobj);
        public Task<OrderIterm> GetById(Guid Id);
        public Task<List<OrderIterm>> Gets();
    }
}
