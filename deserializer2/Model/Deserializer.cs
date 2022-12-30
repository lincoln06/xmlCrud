using deserializer2.Classes;
using deserializer2.Interfaces;

namespace deserializer2.Model
{
    public class Deserializer : SerializerBase, IDeserializer
    {
        private readonly IListViewer _listViewer;
        private readonly IValidator _validator;
        public Deserializer(IListViewer listViewer, IValidator validator)
        {
            _listViewer = listViewer;
            _validator = validator;
        }

        public void ShowCars()
        {
            List<Car> listOfCars = LoadCars();
            _listViewer.ShowCarList(listOfCars);
            
        }
        public override List<Car> LoadCars()
        {
            base.LoadCars();
            return _listOfCars;
        }

        public void Start()
        {
            List<string> listOfErrors = _validator.Validate(_xmlFilePath, _xsdFilePath);
            if (listOfErrors.Count != 0)
            {
                _listViewer.ShowErrors("Plik xml nie jest zgodny ze schematem", listOfErrors);
                Console.WriteLine();
                Console.ReadKey();
                return;
            }
            ShowCars();
        }
    }
}
