using Domain.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountSerivce
    {
        public User[] GetAll()
        {
            return new User[]
            {
                new User { Id = 1, FullName = "Semed Huseynov", Age = 27, Email = "Semed134@mail.com", Password = "Ehmedli18" },
                new User { Id = 2, FullName = "Tunzale Memmedova", Age = 23, Email = "Tunzale134@mail.com" , Password = "Nesimi59" },
                new User { Id = 3, FullName = "Aqsin Veliyeb", Age = 24, Email = "Aqsin134@mail.com" , Password = "Razin1998"},
                new User { Id = 4, FullName = "Meryem  Eliyeva", Age = 20, Email = "Meryen134@mail.com" , Password = "Cat1245" },
                new User { Id = 5, FullName = "Tural Qayibxanov", Age = 36, Email = "Tural134@mail.com" , Password = "Sumqayit50" }
            };



        }


      public string Login(string email, string password)
        {
            var users = GetAll();

            foreach (var user in users)
            {
                if(user.Email == email && user.Password == password)
                {
                    return "Success login";
                }
               
            }
            return "Email or password is wrong";
        }

        


       
        
           
            
                 
            
            
        
    }
}
