using deserializer2.Classes;
using deserializer2.Interfaces;

namespace deserializer2.Model
{
    public class Deserializer : SerializerBase, IDeserializer
    {
        public readonly IMenu _menu;
        public Deserializer(IMenu menu)
        {
            _menu = menu;
        }

        public void ShowCars()
        {
            List<Car> listOfCars = LoadCars();
        }
        public override List<Car> LoadCars()
        {
            base.LoadCars();
            return _listOfCars;
        }
        
    }
}
