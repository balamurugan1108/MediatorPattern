using Crud_Mediator.Comands;
using Crud_Mediator.Model;
using Crud_Mediator.Student_Repositry;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Mediator.Student_Handler
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, StudentModel>
    {
        private readonly IStudent _student;

        public CreateStudentHandler(IStudent studentCls)
        {
            _student = studentCls;
        }

        public async Task<StudentModel> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var Std = new StudentModel()
            {
                Std_ID = request.Std_ID,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Address = request.Address
            };
           return await _student.AddStudent(Std);
        }
    }
}
