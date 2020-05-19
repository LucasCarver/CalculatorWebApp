using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcualtorApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalcualtorApp.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult Calculate(Calculator calculator)
        {
            if(calculator.Operator == '+')
            {
                calculator.Result = calculator.Number1 + calculator.Number2;
            }
            else if(calculator.Operator == '-')
            {
                calculator.Result = calculator.Number1 - calculator.Number2;
            }
            else if(calculator.Operator == '*')
            {
                calculator.Result = calculator.Number1 * calculator.Number2;
            }
            else if(calculator.Operator == '/')
            {
                calculator.Result = calculator.Number1 / calculator.Number2;
            }

            return View("Calculator", calculator);
        }
    }
}
