using FourLeafCloverShoe.Share.Models;

namespace FourLeafCloverShoe.IServices
{
    public interface IRateService
    {
        public Task<bool> Add(Rate obj);
        public Task<bool> AddMany(List<Rate> lstobj);
        public Task<bool> Update(Rate obj);
        public Task<bool> Delete(Guid Id);
        public Task<Rate> GetById(Guid Id);
        public Task<List<Rate>> Gets();
    }
}
