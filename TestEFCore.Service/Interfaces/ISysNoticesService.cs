using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEFCore.Service.Models;

namespace TestEFCore.Service.Interfaces
{
    public interface ISysNoticesService
    {
        Task<IEnumerable<SysNotice>> GetSysNotices();
        Task<SysNotice> GetSysNotice(int id);
        Task<bool> PutSysNotice(int id, SysNotice sysNotice);
        Task<SysNotice> PostSysNotice(SysNotice sysNotice);
        Task<bool> DeleteSysNotice(int id);
    }
}
