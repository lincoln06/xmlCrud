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
            int value;
            bool isAbleToParse = int.TryParse(Console.ReadLine(), out value);
            if(isAbleToParse)  return value;
            return -1;
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
                ushort? year = GetUshortNumberFromUser();
                Console.WriteLine("Rodzaj paliwa");
                string fuelType = Console.ReadLine();
                Console.WriteLine("Pojemność silnika [cm3]");
                ushort? engineSize = GetUshortNumberFromUser();
                Console.WriteLine("Moc [KM]");
                ushort? power = GetUshortNumberFromUser();
                Console.WriteLine("Prędkość maksymalna [km/h]");
                ushort? topSpeed = GetUshortNumberFromUser();
                Console.WriteLine("Kolor");
                string color = Console.ReadLine();
                Car car=new Car { 
                    Manufacturer = manufacturer,
                    Model = model,
                    Year = (ushort)year,
                    FuelType = fuelType,
                    EngineSize = (ushort)engineSize,
                    Power = (ushort)power,
                    TopSpeed = (ushort)topSpeed,
                    Color = color
                };
                bool isDataCorrect = _validator.CheckDataCorrection(car);
                if (!isDataCorrect) throw new Exception("Pola nie mogą być puste");
                return car;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Nieprawidłowa wartość\n{e.Message}");
                return null;
            }
        }

        private ushort? GetUshortNumberFromUser()
        {
            ushort value;
            bool isAbleToParse = ushort.TryParse(Console.ReadLine(), out value);
            if (isAbleToParse) return value;
            return null;
        }
    }
}
