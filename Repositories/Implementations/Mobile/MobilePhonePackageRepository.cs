﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;
using VodakomBlue.Model;
using Microsoft.EntityFrameworkCore;

namespace VodakomBlue.Repositories.Implementations
{
    public class MobilePhonePackageRepository : IMobilePhonePackageRepository
    {
        private readonly AppDbContext dbContext;

        public MobilePhonePackageRepository(AppDbContext context)
        {
            dbContext = context;
        }

        public async Task AddPackageAsync(MobilePhonePackage newPackage)
        {
            await dbContext.MobilePhonePackages.AddAsync(newPackage);
            await dbContext.SaveChangesAsync();
        }

        public void DeletePackage(int packageId)
        {
            MobilePhonePackage mobilePhonePackage = GetPackageAsync(packageId).Result;
            dbContext.Remove(mobilePhonePackage);
            dbContext.SaveChanges();
        }

        public async Task<IEnumerable<MobilePhonePackage>> GetAllPackageAsync()
        {
            return await dbContext.MobilePhonePackages.ToListAsync();
        }

        public async Task<MobilePhonePackage> GetPackageAsync(int packageId)
        {
            return await dbContext.MobilePhonePackages.FindAsync(packageId);
        }
    }
}
