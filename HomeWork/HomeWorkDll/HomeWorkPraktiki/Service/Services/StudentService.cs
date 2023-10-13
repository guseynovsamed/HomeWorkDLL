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
        public Student[] GetAll()
        {
            return new Student[]
            {
                new Student{Id = 1 , FullName = "Semed Huseynov", Age = 26 , Email = "Semed134@mail.ru"},
                new Student{Id = 2 , FullName = "Aqsin Veliyev", Age = 24 , Email = "Aqsin1234@mail.ru"},
                new Student{Id = 3 , FullName = "Ilham Abasli", Age = 20 , Email = "Ilham4@mail.ru"},
                new Student{Id = 4 , FullName = "Tunzale Memmedova", Age = 22 , Email = "Tunzale@mail.ru"}

            };
        }


        public Student[] GetALlStudents()
        {
            return GetAll();
        }


        public Student GetById(int id )
        {
            return GetAll().FirstOrDefault(n => n.Id == id);
        }
    }
}
