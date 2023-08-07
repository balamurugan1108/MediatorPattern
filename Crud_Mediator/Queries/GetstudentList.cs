using Crud_Mediator.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Mediator.Queries
{
    public class GetstudentList:IRequest<List<StudentModel>>
    {
    }
}
