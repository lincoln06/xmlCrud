namespace deserializer2.Interfaces
{
    public interface IMenu
    {
        void ShowMenu();
        void ShowWrongChoiceError();
        void ShowHeader();
        void AskIfUserWantsToExit();
    }
}