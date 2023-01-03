using deserializer2.Classes;
using deserializer2.Interfaces;

namespace deserializer2.Model
{
    public class ResponseProvider : IResponseProvider
    {
        
        public int AskUserWhatToDo()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                return -1;
            }
        }

        public Car GetCarFromUser(int carNumber)
        {
            try
            {
                Console.WriteLine($"Samochód numer {carNumber}");
                Console.WriteLine("Marka");
                string manufacturer = Console.ReadLine();
                Console.WriteLine("Model");
                string model = Console.ReadLine();
                Console.WriteLine("Rok");
                ushort year = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Rodzaj paliwa");
                string fuelType = Console.ReadLine();
                Console.WriteLine("Pojemność silnika [cm3]");
                ushort engineSize = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Moc [KM]");
                ushort topSpeed = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Kolor");
                string color = Console.ReadLine();
                return new Car
                {
                    Manufacturer = manufacturer,
                    Model = model,
                    Year = year,
                    FuelType = fuelType,
                    EngineSize = engineSize,
                    TopSpeed = topSpeed,
                    Color = color
                };
            }
            catch(Exception e)
            {
                Console.WriteLine($"Nieprawidłowa wartość\n{e.Message}");
                return null;
            }
        }
    }
}
