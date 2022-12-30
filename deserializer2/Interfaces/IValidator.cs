namespace deserializer2.Interfaces
{
    public interface IValidator
    {
        List<string> Validate(string xmlFilePath, string xsdFilePath);
    }
}