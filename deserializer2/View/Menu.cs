using deserializer2.Interfaces;
using System.Xml;

namespace deserializer2.View
{
    public class Menu : IMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine($"{new String('-',18)}\n");
            Console.WriteLine("1\tDodaj samochód");
            Console.WriteLine("2\tWyświetl samochody");
        }
        public void WrongChoice()
        {
            Console.WriteLine("Zły wybór");
        }

        public void ShowSerializerOptions()
        {
            Console.WriteLine("Ile samochodów chcesz dodać?");
        }
    }
}
