using Domain.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controller
{
    public class AccountController
    {
        public readonly AccountSerivce _accountSerivce;

        public AccountController()
        {
            _accountSerivce = new AccountSerivce();
        }


        public void GetLogin()
        {
            Console.WriteLine("Add your email:");
            string email = Console.ReadLine();
            Console.WriteLine("Add yout password: ");
            string password = Console.ReadLine();

            var user = _accountSerivce.Login(email, password);
            Console.WriteLine(user);






        }





    }
}
