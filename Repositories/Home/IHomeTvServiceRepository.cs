﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;


namespace VodakomBlue.Repositories
{
    public interface IHomeTvServiceRepository
    {
        Task<IEnumerable<HomeTvService>> GetAllServiceAsync(int userId);
        Task AddServiceAsync(HomeTvService newService);
        void UpdateService(HomeTvService homeService);
        void DeleteService(int serviceId);
    }
}
