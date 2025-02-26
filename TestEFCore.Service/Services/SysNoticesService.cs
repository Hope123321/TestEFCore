using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEFCore.Service.Interfaces;
using TestEFCore.Service.Models;

namespace TestEFCore.Service.Services
{
    public class SysNoticesService : ISysNoticesService
    {
        private readonly RdErpV1Context _context;
        public SysNoticesService(RdErpV1Context context)
        {
            _context = context;
        }
        /// <summary>
        /// 取得總部公告
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<SysNotice>> GetSysNotices()
        {
            if (_context.SysNotices == null)
            {
                return null;
            }
            return await _context.SysNotices.ToListAsync();
        }
        /// <summary>
        /// 取得總部公告
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<SysNotice> GetSysNotice(int id)
        {
            if (_context.SysNotices == null)
            {
                return null;
            }
            var sysNotice = await _context.SysNotices.FindAsync(id);
            if (sysNotice == null)
            {
                return null;
            }
            return sysNotice;
        }
        /// <summary>
        /// 修改總部公告
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sysNotice"></param>
        /// <returns></returns>
        public async Task<bool> PutSysNotice(int id, SysNotice sysNotice)
        {
            if (id != sysNotice.NtcNo)
            {
                return false;
            }
            _context.Entry(sysNotice).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SysNoticeExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }
            return true;
        }
        /// <summary>
        /// 新增總部公告
        /// </summary>
        /// <param name="sysNotice"></param>
        /// <returns></returns>
        public async Task<SysNotice> PostSysNotice(SysNotice sysNotice)
        {
            if (_context.SysNotices == null)
            {
                return null;
            }
            _context.SysNotices.Add(sysNotice);
            await _context.SaveChangesAsync();
            return sysNotice;
        }
        /// <summary>
        /// 刪除總部公告
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteSysNotice(int id)
        {
            if (_context.SysNotices == null)
            {
                return false;
            }
            var sysNotice = await _context.SysNotices.FindAsync(id);
            if (sysNotice == null)
            {
                return false;
            }
            _context.SysNotices.Remove(sysNotice);
            await _context.SaveChangesAsync();
            return true;
        }
        /// <summary>
        /// 確認總部公告是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool SysNoticeExists(int id)
        {
            return _context.SysNotices.Any(e => e.NtcNo == id);
        }
    }
}
