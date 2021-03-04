using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VodakomBlue.Repositories
{
    public interface IHomeTvRepository
    {
        Task<HomeTv> GetHomeTvAsync(int homeTvId);
        Task<IEnumerable<HomeTv>> GetAllHomeTvASync();
        Task AddHomeTvAsync(HomeTv newHomeTv);
        Task DeleteHomeTv(int homeTvId);
    }
}
