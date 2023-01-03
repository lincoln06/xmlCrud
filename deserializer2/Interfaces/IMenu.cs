namespace deserializer2.Interfaces
{
    public interface IMenu
    {
        void AskIfUserWantsToExit();
        void ShowMenu();
        void ShowSerializerOptions();
        void WrongChoice();
    }
}