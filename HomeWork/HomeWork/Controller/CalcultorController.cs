using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controller
{
    public class CalcultorController
    {
        CalculatorService calculatorService = new CalculatorService();

        public void GetOperation()
        {


            Console.WriteLine("Birinci ededi daxil edin:");
            double a = Convert.ToDouble(Console.ReadLine());

        KenarMetod:
            Console.WriteLine("Duzgun Operator Daxil edin");

            Console.WriteLine("Operatoru daxil edin:(+,-,*,/)");
            string op = Console.ReadLine();

            Console.WriteLine("Ikinci ededi daxil edin:");
            double b = Convert.ToDouble(Console.ReadLine());





            if (op == "+")
            {
                Console.WriteLine("Cavab:");

                Console.WriteLine(calculatorService.Addition(a, b));

            }
            else if (op == "-")
            {
                Console.WriteLine("Cavab:");

                Console.WriteLine(calculatorService.Subtraction(a, b));

            }
            else if (op == "*")
            {
                Console.WriteLine("Cavab:");

                Console.WriteLine(calculatorService.Multiplication(a, b));

            }
            else if (op == "/")
            {
                Console.WriteLine("Cavab:");

                Console.WriteLine(calculatorService.Division(a, b));
            }
            else
            {

                goto KenarMetod;
            }

        }






    }



}
