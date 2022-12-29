using deserializer2.Interfaces;
using deserializer2.View;
using deserializer2.Classes;
using System.Xml.Serialization;

namespace deserializer2.Model
{
    public class Serializer : ISerializer
    {
        private readonly Menu _menu;
        private readonly ResponseProvider _responseProvider;
        private readonly string _xmlPath = "Data/Car.xml";
        private readonly XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<Car>));
        public void Start()
        {
            _menu.ShowSerializerOptions();
            int choose = _responseProvider.AskUserWhatToDo();
            if (choose < 1) return;
            List<Car> listOfCars = GenerateList(choose);
            Serialize(listOfCars);

        }

        private void Serialize(List<Car> listOfCars)
        {
            using(var writer=new StreamWriter(_xmlPath))
            {
                _xmlSerializer.Serialize(writer, listOfCars);
            }
        }

        public List<Car> GenerateList(int numberOfCars)
        {
            List<Car> listOfCars= new List<Car>();
            for(int i=0;i<numberOfCars;i++)
            {
                Car car = _responseProvider.GetCarFromUser(i + 1);
                if (car is { }) listOfCars.Add(car);
            }
            return listOfCars;
        }
    }
}
