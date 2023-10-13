using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class StudentService
    {
        public Student[] GetAllStudent()
        {
            return new Student[]
            {
                new Student { Id = 1 , FullName = "Semed Huseynov"  , Age = 27 , Email = "Semed134@mail.com" },
                new Student { Id = 2, FullName = "Tunzale Memmedova", Age = 23, Email = "Tunzale134@mail.com" },
                new Student { Id = 3, FullName = "Aqsin Veliyeb", Age = 24, Email = "Aqsin134@mail.com" },
                new Student { Id = 4, FullName = "Meryem  Eliyeva", Age = 20, Email = "Meryen134@mail.com" },
                new Student { Id = 5, FullName = "Tural Qayibxanov", Age = 36, Email = "Tural134@mail.com" }
            };

        }





        public Student GetStudenId(int id)
        {
            return GetAllStudent().FirstOrDefault(x => x.Id == id);

        }


        public Student[] SortStudent(string sortType)
        {
            if (sortType == "asc")

                return GetAllStudent().OrderBy(x => x.Age).ToArray();


            return GetAllStudent().OrderByDescending(x => x.Age).ToArray();
        }













    }
}
