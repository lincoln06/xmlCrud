using deserializer2.Classes;
using deserializer2.Interfaces;
using deserializer2.View;

namespace deserializer2.Model
{
    public class ResponseProvider : IResponseProvider
    {
        private readonly IValidator _validator;
        private readonly IMenu _menu;
        public ResponseProvider(IValidator validator, IMenu menu)
        {
            _validator= validator;
            _menu = menu;
        }
        public int GetIntNumberFromUser()
        {
            int value=0;
            bool isAbleToParse = false;
            while (isAbleToParse == false)
            {
                isAbleToParse = int.TryParse(Console.ReadLine(), out value);
                if (!isAbleToParse) _menu.ShowWrongValueError();
            }
            return value;
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
                ushort year = GetUshortNumberFromUser();
                Console.WriteLine("Rodzaj paliwa");
                string fuelType = Console.ReadLine();
                Console.WriteLine("Pojemność silnika [cm3]");
                ushort engineSize = GetUshortNumberFromUser();
                Console.WriteLine("Moc [KM]");
                ushort power = GetUshortNumberFromUser();
                Console.WriteLine("Prędkość maksymalna [km/h]");
                ushort topSpeed = GetUshortNumberFromUser();
                Console.WriteLine("Kolor");
                string color = Console.ReadLine();
                bool isDataCorrect = _validator.CheckDataCorrection(manufacturer, model, fuelType, color);
                if (!isDataCorrect) throw new Exception("Pola nie mogą być puste");
                return new Car { 
                    Manufacturer = manufacturer,
                    Model = model,
                    Year = (ushort)year,
                    FuelType = fuelType,
                    EngineSize = (ushort)engineSize,
                    Power = (ushort)power,
                    TopSpeed = (ushort)topSpeed,
                    Color = color
                };
                
                
            }
            catch(Exception e)
            {
                Console.WriteLine($"Nieprawidłowa wartość\n{e.Message}");
                return null;
            }
        }

        private ushort GetUshortNumberFromUser()
        {
            ushort value=0;
            bool isAbleToParse = false;
            while (isAbleToParse == false)
            {
                isAbleToParse = ushort.TryParse(Console.ReadLine(), out value);
                if(!isAbleToParse) _menu.ShowWrongValueError();
            }
            return value;
        }
    }
}
