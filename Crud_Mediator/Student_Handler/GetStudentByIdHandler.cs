using Crud_Mediator.Model;
using Crud_Mediator.Queries;
using Crud_Mediator.Student_Repositry;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Mediator.Student_Handler
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentId ,StudentModel>
    {
        private readonly IStudent _student;
        public GetStudentByIdHandler(IStudent student)
        {
            _student = student;
        }

        public async Task<StudentModel> Handle(GetStudentId request, CancellationToken cancellationToken)
        {
            return await _student.GetStudentId(request.Std_ID);
        }
    }
}
