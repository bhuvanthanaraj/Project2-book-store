using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stu_reg_API.Models;

namespace Stu_reg_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class homeController : ControllerBase
    {

        private readonly StudentRegistaionContext _context;

        public homeController(StudentRegistaionContext context)
        {
            _context = context;
        }

        [EnableCors()]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StuReg>>> Get()
        {
            var studetails = await _context.StuRegs.ToListAsync();
            return Ok(studetails);
        }




        [EnableCors()]
        [HttpPost]
        public async Task<ActionResult<StuReg>> Postbook(StuReg studetails)
        {
            _context.StuRegs.Add(studetails);
            await _context.SaveChangesAsync();

            return Ok(studetails);

        }

    }
}



