using deserializer2.Classes;
using deserializer2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deserializer2.Interfaces
{
    public interface IListViewer
    {
        void ShowCarList(List<Car> listOfCars);
        void ShowErrors(string headerMessage, List<string> listOfErrors);
    }
}
