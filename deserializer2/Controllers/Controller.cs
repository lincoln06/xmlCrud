using deserializer2.Interfaces;

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
