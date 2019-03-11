using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
      /*  public ActionResult Index()
        {
            return View();
        }*/

       public ActionResult FizzBuzz()
        {
            Class liczba = new Class();

            return View(liczba);
        }

        [HttpPost]
        public ActionResult FizzBuzz(Class number)
        {

            if (number.liczba < 1 || number.liczba > 100)
            {
                number.odpowiedz = "Dozwolone są tylko liczby całkowite w przedziale od 1 do 100";
                return View("Odpowiedz", number);
            }

            if (number.liczba % 5 == 0 && number.liczba % 3 == 0)
            {
                number.odpowiedz = "FizzBuzz";
                return View("Odpowiedz", number);
            }

            if (number.liczba % 3 == 0)
            {
                number.odpowiedz = "Fizz";
                return View("Odpowiedz", number);
            }

            if (number.liczba % 5 == 0)
            {
                number.odpowiedz = "Buzz";
                return View("Odpowiedz", number);
            }

            else
            {
                number.odpowiedz = number.liczba.ToString();
                return View("Odpowiedz", number);
            }
        }
    }
}