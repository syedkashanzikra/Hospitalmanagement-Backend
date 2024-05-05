using Hospital_Management_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital_Management_Backend.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {

        private readonly HospitalManagementAppContext _context;
        public StudentAPIController(HospitalManagementAppContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student std)
        {
            await _context.Students.AddAsync(std);
            await _context.SaveChangesAsync();
            return Ok(std);

        }
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            var data = await _context.Students.ToListAsync();
            return Ok(data);  //ok means 200 or success

        }



    }
}
