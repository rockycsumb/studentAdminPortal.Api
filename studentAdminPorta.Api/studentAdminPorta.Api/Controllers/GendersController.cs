using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using studentAdminPorta.Api.DataModels;
using studentAdminPorta.Api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentAdminPorta.Api.Controllers
{
    [ApiController]
    public class GendersController : Controller
    {
        public readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public GendersController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllGenders()
        {
            var gendersList = await studentRepository.GetGendersAsync();

            if(gendersList == null || !gendersList.Any())
            {
                return NotFound();
            }
            return Ok(mapper.Map<List<Gender>>(gendersList));
        }
    }
}
