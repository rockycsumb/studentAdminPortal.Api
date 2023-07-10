using studentAdminPorta.Api.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace studentAdminPorta.Api.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();

        Task<Student> GetStudentAsync(Guid studentId);
    }
}
