using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using studentAdminPorta.Api.DataModels;
using studentAdminPorta.Api.DomainModels;
using studentAdminPorta.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentAdminPorta.Api.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        public readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudentsAsync()
        {
            var students = await studentRepository.GetStudentsAsync();

            return Ok(mapper.Map<List<Student>>(students));
        }
    }
}
