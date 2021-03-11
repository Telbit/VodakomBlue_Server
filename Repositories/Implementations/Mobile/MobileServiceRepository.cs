using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Mobile;

namespace VodakomBlue.Repositories.Implementations
{
    public class MobileServiceRepository : IMobileServiceRepository
    {
        public Task AddServiceAsync(MobileService newService)
        {
            throw new NotImplementedException();
        }

        public Task DeleteServiceAsync(int serviceId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MobileService>> GetServiceAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateServiceAsync(MobileService homeService)
        {
            throw new NotImplementedException();
        }
    }
}
