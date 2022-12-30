using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deserializer2.Interfaces;
using deserializer2.View;

namespace deserializer2.Model
{
    public class App:IApp
    {
        private readonly IMenu _menu;
        private readonly IDeserializer _deserializer;
        private readonly ISerializer _serializer;
        private readonly IResponseProvider _responseProvider;
        private readonly IController _controller;
        private readonly IListViewer _listViewer;
        private readonly IValidator _validator;
        public App(IMenu menu, IDeserializer deserializer, ISerializer serializer, IResponseProvider responseProvider, IController controller, IListViewer listViewer, IValidator validator)
        {
            _menu = menu;
            _deserializer = deserializer;
            _serializer = serializer;
            _responseProvider = responseProvider;
            _controller = controller;
            _listViewer = listViewer;
            _validator = validator;
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
                default:
                    _menu.WrongChoice();
                    _menu.ShowMenu();
                    choose = _responseProvider.AskUserWhatToDo();
                    break;
            }
        }
    }
}
