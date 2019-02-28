using AutoFacExample.IRepository;
using AutoFacExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacExample.Repository
{
    public class StudentRepo : IStudent
    {
        Context context = new Context();
        public Student AddStudent(Student item)
        {
            context.Students.Add(item);
            context.SaveChanges();
            return item;
        }

        public bool DeleteStudent(int id)
        {
            bool isexist = (from x in context.Students select x.StudentID).Any();
            if (isexist)
            {
                Student student = context.Students.FirstOrDefault(y=>y.StudentID==id);
                context.Students.Remove(student);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<StudentViewModel> GetAllStudent()
        {
            List<Student> students = context.Students.ToList();
            List<StudentViewModel> list = new List<StudentViewModel>();
            foreach (var item in students)
            {
                list.Add(new StudentViewModel {

                    DateOfBirth = item.DateOfBirth.ToString("dd.MM.yyyy"),
                    Height=item.Height,
                    StudentID=item.StudentID,
                    StudentName=item.StudentName,
                    Weight=item.Weight

                });
            }
            return list;
        }

        public Student GetStudentByID(int id)
        {
            if (id>0)
            {
                Student student = context.Students.FirstOrDefault(y => y.StudentID == id);
                return student;
            }

            return null;
        }

        public bool UpdateStudent(Student item)
        {
            if (item!=null)
            {
                Student student = context.Students.FirstOrDefault(y => y.StudentID == item.StudentID);
                context.Students.Remove(student);
                context.SaveChanges();
                student.DateOfBirth = item.DateOfBirth;
                student.Height = item.Height;
                student.Weight = item.Weight;
                student.StudentName = item.StudentName;
                context.Students.Add(student);
                context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}