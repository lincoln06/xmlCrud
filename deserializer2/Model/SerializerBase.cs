﻿using deserializer2.Classes;
using System.Xml.Serialization;

namespace deserializer2.Model
{
    public abstract class SerializerBase
    {
        public readonly static string _xmlFilePath = @"Data/Car.xml";
        public readonly XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<Car>));
        public List<Car> _listOfCars=new List<Car>();
        public virtual List<Car> LoadCars()
        {
            using (var reader = new StreamReader(_xmlFilePath))
            {
                List<Car> loadedList = (List<Car>)_xmlSerializer.Deserialize(reader);
                _listOfCars.AddRange(loadedList);
            }
            return _listOfCars;
        }
    }
}