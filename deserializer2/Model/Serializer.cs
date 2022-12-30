using deserializer2.Interfaces;
using deserializer2.Classes;

namespace deserializer2.Model
{
    public class Serializer : SerializerBase, ISerializer
    {
        private readonly IMenu _menu;
        private readonly IResponseProvider _responseProvider;
        
        public Serializer(IMenu menu, IResponseProvider responseProvider)
        {
            _menu = menu;
            _responseProvider=responseProvider;
        }
        public void Start()
        {
            _menu.ShowSerializerOptions();
            int choose = _responseProvider.AskUserWhatToDo();
            if (choose < 1) return;
            List<Car> listOfCars = GenerateList(choose);
            listOfCars.AddRange(LoadCars());
            Serialize(listOfCars);

        }

        private void Serialize(List<Car> listOfCars)
        {
            using(var writer=new StreamWriter(_xmlFilePath))
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
        public override List<Car> LoadCars()
        {
            base.LoadCars();
            return _listOfCars;
        }
    }
}
