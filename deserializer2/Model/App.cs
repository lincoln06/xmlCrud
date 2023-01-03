using deserializer2.Interfaces;

namespace deserializer2.Model
{
    public class App:IApp
    {
        private readonly IMenu _menu;
        private readonly IDeserializer _deserializer;
        private readonly ISerializer _serializer;
        private readonly IResponseProvider _responseProvider;
        public App(IMenu menu, IDeserializer deserializer, ISerializer serializer, IResponseProvider responseProvider)
        {
            _menu = menu;
            _deserializer = deserializer;
            _serializer = serializer;
            _responseProvider = responseProvider;
        }
        public void Start()
        {
            _menu.ShowMenu();
            int choose = _responseProvider.AskUserWhatToDo();
            switch(choose)
            {
                case 1:
                    _serializer.Start();
                    break;
                case 2:
                    _deserializer.Start();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    _menu.WrongChoice();
                    _menu.ShowMenu();
                    choose = _responseProvider.AskUserWhatToDo();
                    break;
            }
            _menu.AskIfUserWantsToExit();
            choose= _responseProvider.AskUserWhatToDo();
            switch(choose)
            {
                case 1:
                    Environment.Exit(0);
                    break;
                case 2:
                    Start();
                    break;
                default:
                    _menu.WrongChoice();
                    _menu.AskIfUserWantsToExit();
                    choose = _responseProvider.AskUserWhatToDo();
                    break;
            }
        }
    }
}
