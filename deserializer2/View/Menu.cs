using deserializer2.Interfaces;

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
            Console.WriteLine("3\tWyjdź");
        }
        public void ShowWrongChoiceError()
        {
            Console.WriteLine("Zły wybór");
        }
        public void ShowHeader()
        {
            Console.Clear();
            Console.WriteLine(new String('-',20));
            Console.WriteLine("Lista samochodów:");
            Console.WriteLine(new String('-', 20));
            Console.WriteLine();
        }

        public void AskIfUserWantsToExit()
        {
            Console.WriteLine("Czy chcesz wyjść?\n");
            Console.WriteLine("1\tTak");
            Console.WriteLine("2\tNie");
        }

        public void ShowWrongValueError()
        {
            Console.WriteLine("Nieprawidłowa wartość. Podaj jeszcze raz");
        }
    }
}
