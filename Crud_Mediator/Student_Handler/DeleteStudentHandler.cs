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
    public class DeleteStudentHandler : IRequestHandler<DeleteStudentCommand,int>
    {
        private readonly IStudent _student;
        public DeleteStudentHandler(IStudent student)
        {
            _student = student;
        }

        public async Task<int> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            var studentDetails = await _student.GetStudentId(request.Std_ID);
            if (studentDetails == null)
                return default;
            return await _student.DeleteStudent(request.Std_ID);
        }
    }
}
