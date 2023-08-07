using MediatR;
using Crud_Mediator.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Crud_Mediator.Queries;
using Crud_Mediator.Comands;

namespace Mediator_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentController(IMediator mediator)
        {
           this._mediator = mediator;
        }
        [HttpGet("GetStudents")]
        public async Task<List<StudentModel>> GetStudentsListAsync()
        {
            var StudentDetails = await _mediator.Send(new GetstudentList());
            return StudentDetails;
        }
        [HttpGet("StudentId")]
        public async Task<StudentModel> GetStudentByIdAsync(int studentId)
        {
            var StdDetails = await _mediator.Send(new GetStudentId() { Std_ID = studentId });

            return StdDetails;
        }

        [HttpPost("AddStudents")]
        public async Task<StudentModel> AddStudent (StudentModel StudentDetails)
        {
            var stdDetails = await _mediator.Send(new CreateStudentCommand(
                StudentDetails.Std_ID,
                StudentDetails.FirstName,
                StudentDetails.LastName,
                StudentDetails.Age,
                StudentDetails.Address
                ));
            return stdDetails;
        }

        [HttpPut("UpdateStudents")]
        public async Task<int> UpdateStudentAsync(StudentModel StudentDetails)
        {
            var updateStdDetails = await _mediator.Send(new UpdateStudentComand(
                StudentDetails.Std_ID,
                StudentDetails.FirstName,
                StudentDetails.LastName,
                StudentDetails.Age,
                StudentDetails.Address));
            return updateStdDetails;
        }

        [HttpDelete("DeleteStudents")]
        public async Task<int> DeleteStudentAsync(int Id)
        {
            return await _mediator.Send(new DeleteStudentCommand() { Std_ID = Id });
        }
    }
}
