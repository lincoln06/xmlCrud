using deserializer2.Interfaces;

namespace deserializer2.Model
{
    public class App:IApp
    {
        private readonly IMenu _menu;
        private readonly IDeserializer _deserializer;
        private readonly ISerializer _serializer;
        private readonly IResponseProvider _responseProvider;
        private readonly IValidator _validator;
        public App(IMenu menu, IDeserializer deserializer, ISerializer serializer, IResponseProvider responseProvider, IValidator validator)
        {
            _menu = menu;
            _deserializer = deserializer;
            _serializer = serializer;
            _responseProvider = responseProvider;
            _validator = validator;
        }
        public void Start()
        {
            _menu.ShowMenu();
            int choice = _responseProvider.GetIntNumberFromUser();
            switch(choice)
            {
                case 1:
                    _serializer.Start();
                    _menu.ShowHeader();
                    _deserializer.Start();
                    break;
                case 2:
                    _deserializer.Start();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    _menu.ShowWrongChoiceError();
                    break;
            }
        }
    }
}
