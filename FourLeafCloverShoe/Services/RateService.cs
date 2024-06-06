using FourLeafCloverShoe.Data;
using FourLeafCloverShoe.IServices;
using FourLeafCloverShoe.Share.Models;
using Microsoft.EntityFrameworkCore;

namespace FourLeafCloverShoe.Services
{
    public class RateService : IRateService
    {
        private readonly MyDbContext _myDbContext;

        public RateService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public async Task<bool> Add(Rate obj)
        {
            try
            {
                await _myDbContext.Rates.AddAsync(obj);
                await _myDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> AddMany(List<Rate> lstobj)
        {
            try
            {
                await _myDbContext.Rates.AddRangeAsync(lstobj);
                await _myDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> Delete(Guid Id)
        {
            try
            {
                var obj = await GetById(Id);
                if (obj != null)
                {
                    _myDbContext.Rates.Remove(obj);
                    await _myDbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<Rate> GetById(Guid Id)
        {
            try
            {
                var obj = await _myDbContext.Rates.FindAsync(Id);
                if (obj != null)
                {

                    return obj;
                }
                return new Rate();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Rate();
            }
        }

        public async Task<List<Rate>> Gets()
        {
            try
            {
                var obj = await _myDbContext.Rates.ToListAsync();
                if (obj != null)
                {

                    return obj;
                }
                return new List<Rate>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Rate>();
            }
        }

        public async Task<bool> Update(Rate obj)
        {
            try
            {
                var objFromDb = await GetById(obj.Id);
                if (obj != null)
                {
                    objFromDb.Contents = obj.Contents;
                    objFromDb.Reply = obj.Reply;
                    objFromDb.ImageUrl = obj.ImageUrl;
                    objFromDb.Rating = obj.Rating;
                    objFromDb.Status = obj.Status;
                    _myDbContext.Rates.Update(objFromDb);
                    await _myDbContext.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}