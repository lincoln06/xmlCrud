using deserializer2.Classes;
using deserializer2.Interfaces;
using System.Reflection.Metadata.Ecma335;
using System.Xml;
using System.Xml.Schema;

namespace deserializer2.Model
{
    public class Validator : IValidator
    {
        public List<string> _listOfErrors = new List<string>();

        public bool CheckDataCorrection(Car car)
        {
            if (car.Manufacturer == String.Empty || car.Model == String.Empty || car.FuelType == String.Empty || car.Color == String.Empty)
                return false;
            if (car.Year is null || car.TopSpeed is null || car.Power is null || car.EngineSize is null) return false;
            return true;
        }

        public List<string> Validate(string xmlFilePath, string xsdFilePath)
        {
            XmlReaderSettings settings = new();
            settings.ValidationType= ValidationType.Schema;
            settings.Schemas.Add("",xsdFilePath);
            settings.ValidationEventHandler += ValidationEventHandler;
            XmlReader reader=XmlReader.Create(xmlFilePath,settings);
            while (reader.Read())
            {

            }
            return _listOfErrors;
        }

        private void ValidationEventHandler(object? sender, ValidationEventArgs e)
        {
            _listOfErrors.Add(e.Message);
        }
    }
}
