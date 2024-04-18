﻿using FourLeafCloverShoe.Share.Models;

namespace FourLeafCloverShoe.IServices
{
    public interface IUserVoucherService
    {
        public Task<bool> Add(UserVoucher obj);
        public Task<bool> AddMany(List<UserVoucher> lstobj);
        public Task<bool> Update(UserVoucher obj);
        public Task<bool> Delete(Guid Id);
        public Task<UserVoucher> GetById(Guid Id);
        public Task<List<UserVoucher>> Gets();
    }
}