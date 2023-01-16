using deserializer2.Classes;

namespace deserializer2.Interfaces
{
    public interface IListViewer
    {
        void ShowCarList(IEnumerable<Car> listOfCars);
        void ShowErrors(string headerMessage, IEnumerable<string> listOfErrors);
    }
}
