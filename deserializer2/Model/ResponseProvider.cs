using deserializer2.Classes;
using deserializer2.Interfaces;

namespace deserializer2.Model
{
    public class ResponseProvider : IResponseProvider
    {
        private readonly IValidator _validator;
        public ResponseProvider(IValidator validator)
        {
            _validator= validator;
        }
        public int GetIntNumberFromUser()
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

        public Car? GetCarFromUser()
        {
            try
            {
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
                ushort power = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Pręskość maksymalna [km/h]");
                ushort topSpeed = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Kolor");
                string color = Console.ReadLine();
                bool isDataCorrect = _validator.CheckDataCorrection(manufacturer, model, fuelType, color);
                if (!isDataCorrect) throw new Exception("Pola nie mogą być puste");
                return new Car
                {
                    Manufacturer = manufacturer,
                    Model = model,
                    Year = year,
                    FuelType = fuelType,
                    EngineSize = engineSize,
                    Power = power,
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
