using deserializer2.Interfaces;
using System.Xml;
using System.Xml.Schema;

namespace deserializer2.Model
{
    public class Validator : IValidator
    {
        public List<string> _listOfErrors = new List<string>();
        public List<string> Validate(string xmlFilePath, string xsdFilePath)
        {
            XmlReaderSettings settings = new();
            settings.ValidationType= ValidationType.Schema;
            settings.Schemas.Add("",xsdFilePath);
            settings.ValidationEventHandler += ValidationEventHandler;
            XmlReader reader=XmlReader.Create(xmlFilePath,settings);
            while(reader.Read())
            {
                
            }
            return _listOfErrors;
        }

        private void ValidationEventHandler(object? sender, ValidationEventArgs e)
        {
            _listOfErrors.Add(e.Message);
            //Console.WriteLine($"Błąd walidacji: {0}{e.Message}");
        }
    }
}
