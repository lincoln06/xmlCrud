using deserializer2.Classes;
using deserializer2.Interfaces;

namespace deserializer2.View
{
    public class ListViewer : IListViewer
    {
        public void ShowCarList(List<Car> listOfCars)
        {
            int number = 1;
            foreach(Car car in listOfCars)
            {
                Console.WriteLine($"Samochód nr {number}");
                Console.WriteLine($"{ new String('-', 16)}\n");
                Console.WriteLine($"Marka\t{car.Manufacturer}");
                Console.WriteLine($"Model\t{car.Model}");
                Console.WriteLine($"Rok produkcji\t{car.Year}");
                Console.WriteLine($"Rodzaj paliwa\t{car.FuelType}");
                Console.WriteLine($"Pojemnośc silnika [cm3]\t{car.EngineSize}");
                Console.WriteLine($"Moc[KM]\t{car.Power}");
                Console.WriteLine($"Kolor\t{car.Color}");
                Console.WriteLine();
                number++;
            }
        }

        public void ShowErrors(string headerMessage, List<string> listOfErrors)
        {
            Console.WriteLine($"{new String('-',16)}");
            Console.WriteLine(headerMessage);
            Console.WriteLine($"{new String('-', 16)}\n");
            foreach (string error in listOfErrors) Console.WriteLine(error);
        }
    }
}
