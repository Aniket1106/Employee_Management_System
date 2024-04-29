using Employee_Management_System.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Employee_Management_System.models.DBContext;


namespace Employee_Management_System.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly DBContext _context;
        public EmployeeController(DBContext context)
        {
            _context = context;
        }

        [HttpGet("GetInfo")]
        public IActionResult GetInfo()
        {
            try
            {
                var details = _context.Emp_Details.ToList();
                return Ok(details);
            }
            catch (Exception ee)
            {
                return Ok(ee.Message);
            }

            
        }
    }
}
