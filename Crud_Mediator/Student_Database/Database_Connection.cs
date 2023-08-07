using Crud_Mediator.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Mediator.Student_Database
{
    public class Database_Connection:DbContext
    {
        protected readonly IConfiguration _configuration;
        public Database_Connection(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("Database"));
        }  
        public DbSet<StudentModel> Students { get; set; }
    }
}
