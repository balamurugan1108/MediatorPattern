using Crud_Mediator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Mediator.Student_Repositry
{
    public interface IStudent
    {
        public Task<List<StudentModel>> GetStudents();
        public Task<StudentModel> GetStudentId(int stdId);
        public Task<StudentModel> AddStudent(StudentModel student);
        public Task<int> UpdateStudent(StudentModel student);
        public Task<int> DeleteStudent(int employeeId);
    }
}
