using deserializer2.Classes;

namespace deserializer2.Interfaces
{
    public interface IResponseProvider
    {
        int GetIntNumberFromUser();
        Car? GetCarFromUser();
    }
}