using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Mediator.Comands
{
    public class DeleteStudentCommand:IRequest<int>
    {
        public int Std_ID { get; set; }
    }
}
