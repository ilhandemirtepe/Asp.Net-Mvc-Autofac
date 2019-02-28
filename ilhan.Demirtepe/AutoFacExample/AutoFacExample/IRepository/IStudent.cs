using AutoFacExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacExample.IRepository
{
    public interface IStudent
    {
        List<StudentViewModel> GetAllStudent();
        Student GetStudentByID(int id);
        Student AddStudent(Student item);
        bool UpdateStudent(Student item);
        bool DeleteStudent(int id);
    }
}
