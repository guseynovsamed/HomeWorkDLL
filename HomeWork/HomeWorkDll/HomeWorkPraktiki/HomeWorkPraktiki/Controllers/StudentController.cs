using Service.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPraktiki.Controllers
{
    public class StudentController
    {
        private readonly StudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }


        public void GetAllStudent()
        {
            var student = _studentService.GetALlStudents();

            foreach (var item in student)
            {
                Console.WriteLine(item.FullName);
            }

        }


        public void GetByStudentId()
        {
            var student = _studentService.GetById(1);
            Console.WriteLine(student.FullName);
        }


        public void SumOfStudentAge()
        {
            var student = _studentService.GetALlStudents();

            var sumAge = student.Sum(x => x.Age);


            Console.WriteLine(sumAge);

        }


        public void AvereOfStudentAge()
        {
            var student = _studentService.GetALlStudents();

            var sumAge = student.Sum(x=>x.Age);

            Console.WriteLine(sumAge/student.Length);
        }





    }
}
