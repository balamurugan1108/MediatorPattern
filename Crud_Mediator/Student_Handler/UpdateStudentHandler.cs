using Crud_Mediator.Comands;
using Crud_Mediator.Student_Repositry;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Mediator.Student_Handler
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentComand,int>
    {
        private readonly IStudent _student;
        public UpdateStudentHandler(IStudent student)
        {
            _student = student;
        }

        public async Task<int> Handle(UpdateStudentComand request, CancellationToken cancellationToken)
        {
            var studentDetails = await _student.GetStudentId(request.Std_ID);
            if (studentDetails == null)
                return default;

            studentDetails.FirstName = request.FirstName;
            studentDetails.LastName = request.LastName;
            studentDetails.Age = request.Age;
            studentDetails.Address = request.Address;

            return await _student.UpdateStudent(studentDetails);
        }
    }
}
