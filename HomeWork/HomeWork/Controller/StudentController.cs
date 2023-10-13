using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controller
{
    public class StudentController
    {
        private readonly StudentService _studentService;

        public StudentController()
        {
            _studentService = new StudentService();
        }


        public void ShowStudent()
        {
            foreach (var student in _studentService.GetAllStudent())
            {
                Console.WriteLine(student.FullName + " " + student.Email + " " + student.Age);

            }

        }


        public void GetStudent()
        {
            var result = _studentService.GetStudenId(2);


            Console.WriteLine(result.FullName + " " + result.Email + " " + result.Age);
        }



        public void SortStudent()
        {
            Console.WriteLine("Choose one option for sorting: ");

            string sortText = Console.ReadLine();


            foreach (var student in _studentService.SortStudent(sortText))
            {
                Console.WriteLine(student.FullName + " " + student.Age);
            }
        }



        public void AvereOfStudentAge()
        {
            var student = _studentService.GetAllStudent();

            var sumAge = student.Sum(x => x.Age);

            Console.WriteLine(sumAge / student.Length);


            ///}




        }
    }

}