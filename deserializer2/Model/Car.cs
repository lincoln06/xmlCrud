using deserializer2.Interfaces;
using System.Xml.Serialization;

namespace deserializer2.Classes
{
    
    [XmlRoot("CarDetails")]
    
    public class Car:ICar
    {
        [XmlElement("CarManufacturer")]
        public string Manufacturer { get; set; }
        [XmlElement("CarModel")]
        public string Model { get; set; }
        [XmlElement("CarYearOfProduction")]
        public ushort Year { get; set; }
        [XmlElement("CarFuelType")]
        public string FuelType { get; set; }
        [XmlElement("CarEngineSize")]
        public ushort EngineSize { get; set; }
        [XmlElement("CarPower")]
        public ushort Power { get; set; }
        [XmlElement("CarTopSpeed")]
        public ushort TopSpeed { get; set; }
        [XmlElement("CarColor")]
        public string Color { get; set; }
    }
}
