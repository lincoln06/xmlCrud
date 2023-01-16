namespace deserializer2.Interfaces
{
    public interface IValidator
    {
        bool CheckDataCorrection(string arg1, string arg2, string arg3, string arg4);
        List<string> Validate(string xmlFilePath, string xsdFilePath);
    }
}