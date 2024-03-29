﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class HomeInternetRepository : IHomeInternetRepository
    {
        private readonly AppDbContext dbContext;

        public HomeInternetRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddHomeInternetAsync(HomeInternet newHomeInternet)
        {
            await dbContext.HomeInternets.AddAsync(newHomeInternet);
            await dbContext.SaveChangesAsync();
        }

        public void DeleteHomeInternet(int homeInternetId)
        {
            HomeInternet homeInternet = GetHomeInternetAsync(homeInternetId).Result;
            dbContext.Remove(homeInternet);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<HomeInternet>> GetAllHomeInternetAsync()
        {
            return await dbContext.HomeInternets.ToListAsync();
        }

        public async Task<HomeInternet> GetHomeInternetAsync(int homeInternetId)
        {
            return await dbContext.HomeInternets.FindAsync(homeInternetId);
        }
    }
}
