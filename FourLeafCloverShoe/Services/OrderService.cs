using FourLeafCloverShoe.Data;
using FourLeafCloverShoe.IServices;
using FourLeafCloverShoe.Share.Models;
using Microsoft.EntityFrameworkCore;

namespace FourLeafCloverShoe.Services
{
    public class OrderService : IOrderService
    {
        private readonly MyDbContext _myDbContext;

        public OrderService(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public async Task<bool> Add(OrderIterm obj)
        {
            try
            {
                obj.CreateDate = DateTime.Now;
                await _myDbContext.Orders.AddAsync(obj);
                await _myDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<bool> AddMany(List<OrderIterm> lstobj)
        {
            try
            {
                await _myDbContext.Orders.AddRangeAsync(lstobj);
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
                    _myDbContext.Orders.Remove(obj);
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

        public async Task<bool> DeleteMany(List<OrderIterm> lstobj)
        {
            try
            {
                _myDbContext.Orders.RemoveRange(lstobj);
                await _myDbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public async Task<OrderIterm> GetById(Guid Id)
        {
            try
            {
                var obj = (await Gets()).FirstOrDefault(c => c.Id == Id);
                if (obj != null)
                {

                    return obj;
                }
                return new OrderIterm();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new OrderIterm();
            }
        }

        public async Task<List<OrderIterm>> Gets()
        {
            try
            {
                var obj = await _myDbContext.Orders
                    .Include(c => c.OrderItems)
                        .ThenInclude(c => c.ProductDetails)
                            .ThenInclude(c => c.Products)
                            .ThenInclude(c=>c.ProductImages)
                    .Include(c => c.OrderItems)
                        .ThenInclude(c => c.ProductDetails)
                            .ThenInclude(c => c.Size)
                    .Include(c=>c.OrderItems)//them lay tu bang rate
                        .ThenInclude(c=>c.Rate)
                    .ToListAsync();
                if (obj != null)
                {

                    return obj;
                }
                return new List<OrderIterm>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<OrderIterm>();
            }
        }

        public async Task<bool> Update(OrderIterm obj)
        {
            try
            {
                var objFromDb = await GetById(obj.Id);
                if (obj != null)
                {
                    objFromDb.StaffId = obj.StaffId;
                    objFromDb.VoucherId = obj.VoucherId;
                    objFromDb.OrderCode = obj.OrderCode;
                    objFromDb.CoinsUsed = obj.CoinsUsed;
                    objFromDb.PaymentType = obj.PaymentType;
                    objFromDb.OrderStatus = obj.OrderStatus;
                    objFromDb.RecipientName = obj.RecipientName;
                    objFromDb.RecipientAddress = obj.RecipientAddress;
                    objFromDb.RecipientPhone = obj.RecipientPhone;
                    objFromDb.TotalAmout = obj.TotalAmout;
                    objFromDb.VoucherValue = obj.VoucherValue;
                    objFromDb.ShippingFee = obj.ShippingFee;
                    objFromDb.UpdateDate = DateTime.Now;
                    objFromDb.ShipDate = obj.ShipDate;
                    objFromDb.PaymentDate = obj.PaymentDate;
                    objFromDb.DeliveryDate = obj.DeliveryDate;
                    objFromDb.Description = obj.Description;
                    _myDbContext.Orders.Update(objFromDb);
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
