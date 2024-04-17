using FourLeafCloverShoe.Data;
using FourLeafCloverShoe.IServices;
using FourLeafCloverShoe.Share.Models;
using Microsoft.EntityFrameworkCore;

namespace FourLeafCloverShoe.Services
{
    public class CartItemService : ICartItemItemService
    {
        private readonly MyDbContext _myDbContext;

        public CartItemService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public async Task<bool> Add(CartItem obj)
        {
            try
            {
                await _myDbContext.CartItems.AddAsync(obj);
                await _myDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> AddMany(List<CartItem> lstobj)
        {
            try
            {
                await _myDbContext.CartItems.AddRangeAsync(lstobj);
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
                    _myDbContext.CartItems.Remove(obj);
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

        public async Task<CartItem> GetById(Guid Id)
        {
            try
            {
                var obj = await _myDbContext.CartItems.FindAsync(Id);
                if (obj != null)
                {

                    return obj;
                }
                return new CartItem();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new CartItem();
            }
        }

        public async Task<List<CartItem>> Gets()
        {
            try
            {
                var obj = await _myDbContext.CartItems.ToListAsync();
                if (obj != null)
                {

                    return obj;
                }
                return new List<CartItem>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<CartItem>();
            }
        }

        public async Task<bool> Update(CartItem obj)
        {
            try
            {
                var objFromDb = await GetById(obj.Id);
                if (obj != null)
                {
                    objFromDb.Quantity = obj.Quantity;
                    _myDbContext.CartItems.Update(objFromDb);
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
