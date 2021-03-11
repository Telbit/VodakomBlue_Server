using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VodakomBlue.Model.Home;


namespace VodakomBlue.Repositories
{
    public interface IHomeTVRepository
    {
        Task<HomeTV> GetHomeTvAsync(int homeTvId);
        Task<IEnumerable<HomeTV>> GetAllHomeTvASync();
        Task AddHomeTvAsync(HomeTV newHomeTv);
        void DeleteHomeTv(int homeTvId);
    }
}
