using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using deserializer2.Interfaces;

namespace deserializer2.Model
{
    public class Deserializer : IDeserializer
    {
        public readonly IMenu _menu;
        public Deserializer(IMenu menu)
        {
            _menu = menu;
        }

        public void ShowCars()
        {
            //TODO Pokazywanie listy samochodów
            throw new NotImplementedException();
        }
    }
}
