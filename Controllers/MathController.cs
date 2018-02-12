using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MathProgram.Models;

namespace MathProgram.Controllers
{
    public class MathController : Controller
    {
         [HttpGet]
        public IActionResult Addition(int value1, int value2)
        {
            
            if (value1 > 0 && value2 > 0)
            {
                double result = value1 + value2;

                this.ViewBag.firstNumber = value1.ToString();
                this.ViewBag.secondNumber = value2.ToString();
                this.ViewBag.Sum = result.ToString();

                return this.View();
            }

            this.ViewBag.Sum = this.ViewBag.firstNumber = this.ViewBag.secondNumber = 0;
            return this.View();  
        }

        [HttpPost]
        public IActionResult Addition(Response response)
        {   
           
            
            return View();
        }
        [HttpGet]
        public IActionResult Subtraction()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Subtraction(int value1, int value2)
        {   
           
            
            return View();
        }
        [HttpGet]
        public IActionResult DropDown()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Dropdown(string add, string sub, string div, string mult, string mod)
        {   
            
            
            return View();
        }

        [HttpGet]
        public IActionResult Division()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Division(int value1, int value2)
        {   
           
            
            return View();
        }

        [HttpGet]
        public IActionResult Multiplication()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Multiplication(int value1, int value2)
        {   
           
            
            return View();
        }
        [HttpGet]
        public IActionResult Modulus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Modulus(int value1, int value2)
        {   
           
            
            return View();
        }

        public ViewResult Solve()
        {
            return View();
        }
        
        

      

        
    }
}
