using FourLeafCloverShoe.Data;
using FourLeafCloverShoe.IServices;
using FourLeafCloverShoe.Share.Models;
using Microsoft.EntityFrameworkCore;

namespace FourLeafCloverShoe.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly MyDbContext _myDbContext;

        public OrderItemService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public async Task<bool> Add(OrderItem obj)
        {
            try
            {
                await _myDbContext.OrderItems.AddAsync(obj);
                await _myDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> AddMany(List<OrderItem> lstobj)
        {
            try
            {
                await _myDbContext.OrderItems.AddRangeAsync(lstobj);
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
                    _myDbContext.OrderItems.Remove(obj);
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

        public async Task<bool> DeleteMany(List<OrderItem> lstobj)
        {
            try
            {
                 _myDbContext.OrderItems.RemoveRange(lstobj);
                await _myDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<OrderItem> GetById(Guid Id)
        {
            try
            {
                var obj = await _myDbContext.OrderItems.FindAsync(Id);
                if (obj != null)
                {

                    return obj;
                }
                return new OrderItem();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new OrderItem();
            }
        }

        public async Task<List<OrderItem>> Gets()
        {
            try
            {
                var obj = await _myDbContext.OrderItems
                    .Include(c=>c.ProductDetails)
                        .ThenInclude(c=>c.Products)
                            .ThenInclude(c=>c.ProductImages)
                    .Include(c=>c.ProductDetails)
                        .ThenInclude(c=>c.Size)
                    .ToListAsync();
                if (obj != null)
                {

                    return obj;
                }
                return new List<OrderItem>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<OrderItem>();
            }
        }

        public async Task<bool> Update(OrderItem obj)
        {
            try
            {
                var objFromDb = await GetById(obj.Id);
                if (obj != null)
                {
                    objFromDb.Quantity = obj.Quantity;
                    objFromDb.Price = obj.Price;
                    _myDbContext.OrderItems.Update(objFromDb);
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