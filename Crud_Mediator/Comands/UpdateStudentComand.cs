using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Mediator.Comands
{
    public class UpdateStudentComand:IRequest<int>
    {
        public int Std_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
   

        public UpdateStudentComand(int std_ID, string firstName, string lastName,int age, string address)
        {
            Std_ID = std_ID;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
        }
    }
}
