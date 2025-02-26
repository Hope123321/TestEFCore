using Microsoft.AspNetCore.Mvc;
using TestEFCore.Service.Interfaces;
using TestEFCore.Service.Models;

namespace TestEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysNoticesController : ControllerBase
    {
        private ISysNoticesService _SysNoticesService;

        public SysNoticesController(ISysNoticesService SysNoticesService)
        {
            _SysNoticesService = SysNoticesService;
        }

        // GET: api/SysNotices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SysNotice>>> GetSysNotices()
        {
            var sysNotices = await  _SysNoticesService.GetSysNotices();
            return Ok(sysNotices);
        }

        // GET: api/SysNotices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SysNotice>> GetSysNotice(int id)
        {
            var sysNotice = await _SysNoticesService.GetSysNotice(id);
            return Ok(sysNotice);
        }

        // PUT: api/SysNotices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSysNotice(int id, SysNotice sysNotice)
        {
            bool result = await _SysNoticesService.PutSysNotice(id, sysNotice);
            return result?Ok(sysNotice):NoContent();
        }

        // POST: api/SysNotices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SysNotice>> PostSysNotice(SysNotice sysNotice)
        {
            var ret = await _SysNoticesService.PostSysNotice(sysNotice);
            return Ok(ret);
        }

        // DELETE: api/SysNotices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSysNotice(int id)
        {
            bool result = await _SysNoticesService.DeleteSysNotice(id);
            return Ok(result);
        }
    }
}
