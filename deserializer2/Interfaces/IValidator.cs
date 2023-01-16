using deserializer2.Classes;

namespace deserializer2.Interfaces
{
    public interface IValidator
    {
        bool CheckDataCorrection(Car car);
        List<string> Validate(string xmlFilePath, string xsdFilePath);
    }
}