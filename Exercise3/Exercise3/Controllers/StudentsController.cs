using Exercise3.Models.DTOs;
using Exercise3.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exercise3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsRepository _studentsRepository;
        public StudentsController(IStudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{index}")]
        public async Task<IActionResult> Get(string index)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{index}")]
        public async Task<IActionResult> Put(string index, StudentPUT newStudentData)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> Post(StudentPOST newStudent)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{index}")]
        public async Task<IActionResult> Delete(string index)
        {
            throw new NotImplementedException();
        }

    }
}
