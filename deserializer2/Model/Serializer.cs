using deserializer2.Interfaces;
using deserializer2.Classes;

namespace deserializer2.Model
{
    public class Serializer : SerializerBase, ISerializer
    {
        private readonly IResponseProvider _responseProvider;
        
        public Serializer(IResponseProvider responseProvider)
        {
            _responseProvider=responseProvider;
        }
        public void Start()
        {
            Car car = _responseProvider.GetCarFromUser();
            List<Car> listOfCars=LoadCars();
            if (car is not null) listOfCars.Add(car);
            Serialize(listOfCars);
        }
        private void Serialize(List<Car> listOfCars)
        {
            using(var writer=new StreamWriter(_xmlFilePath))
            {
                _xmlSerializer.Serialize(writer, listOfCars);
            }
        }
        public override List<Car> LoadCars()
        {
            base.LoadCars();
            return _listOfCars;
        }
    }
}
