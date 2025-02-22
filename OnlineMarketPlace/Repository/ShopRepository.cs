﻿using Microsoft.EntityFrameworkCore;
using OnlineMarketPlace.Models;

namespace OnlineMarketPlace.Repository
{
    public class ShopRepository
    {
        private readonly OnlineShoppingContext _context;

        public ShopRepository()
        {
            _context = new OnlineShoppingContext();
        }

        public async Task<Shop?> GetShopByIdAsync(int id)
        {
            return await _context.Shops
                .FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
        }

        

        //public async Task<List<Product>>



    }
}
