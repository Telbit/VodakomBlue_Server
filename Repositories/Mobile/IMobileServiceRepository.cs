﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;


namespace VodakomBlue.Repositories
{
    public interface IMobileServiceRepository
    {
        Task<IEnumerable<MobileService>> GetServicesAsync(int customerId);
        Task AddServiceAsync(MobileService newService);
        void UpdateService(MobileService homeService);
        void DeleteService(int serviceId, int customerId);
    }
}
