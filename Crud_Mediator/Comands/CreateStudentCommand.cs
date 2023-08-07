using Crud_Mediator.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Mediator.Comands
{
    public class CreateStudentCommand:IRequest<StudentModel>
    {
        public int Std_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
       

        public CreateStudentCommand(int stdid, string firstName, string lastName,int age, string address)
        {
            Std_ID = stdid;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
        }
    }

}
