using Crud_Mediator.Model;
using Crud_Mediator.Student_Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_Mediator.Student_Repositry
{
    public class Student : IStudent
    {
        private readonly Database_Connection _context;
        public Student(Database_Connection context)
        {
            _context = context;
        }
        public async Task<List<StudentModel>> GetStudents()
        {
            var data = await _context.Students.ToListAsync();
            return data; 
        }
        public async Task<StudentModel> GetStudentId(int stdId)
        {
            var findData = await _context.Students.Where(a =>a.Std_ID == stdId).FirstOrDefaultAsync();
            return findData;
        }
        public async Task<StudentModel> AddStudent(StudentModel student)
        {
            var addData = _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return addData.Entity;
        }
        public async Task<int> UpdateStudent(StudentModel student)
        {
             _context.Students.Update(student);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> DeleteStudent(int stdId)
        {
            var deleteData = _context.Students.Where(a => a.Std_ID == stdId).FirstOrDefault();
            _context.Remove(deleteData);
            return await _context.SaveChangesAsync();
        }

    }
}
