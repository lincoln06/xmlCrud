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

        public bool CheckDataCorrection(string arg1, string arg2, string arg3, string arg4)
        {
            if (arg1 == String.Empty || arg2 == String.Empty || arg3 == String.Empty || arg4 == String.Empty)
                return false;
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
