using deserializer2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deserializer2.Controllers
{
    public class Controller : IController
    {
        public void AddCars()
        {
            Console.WriteLine("Dodajemy samochody");
        }

        public void ShowCars()
        {
            Console.WriteLine("Pokazuję samochody");
        }
    }
}
