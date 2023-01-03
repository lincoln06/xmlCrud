using deserializer2.Interfaces;
using System.Xml.Serialization;

namespace deserializer2.Classes
{

    [Serializable]
    [XmlRoot("ArrayOfCar")]
    
    public class Car:ICar
        
    {
        [XmlElement("Manufacturer")]
        public string Manufacturer { get; set; }
        [XmlElement("Model")]
        public string Model { get; set; }
        [XmlElement("Year")]
        public ushort Year { get; set; }
        [XmlElement("Fuel")]
        public string FuelType { get; set; }
        [XmlElement("EngineSize")]
        public ushort EngineSize { get; set; }
        [XmlElement("Power")]
        public ushort Power { get; set; }
        [XmlElement("TopSpeed")]
        public ushort TopSpeed { get; set; }
        [XmlElement("Color")]
        public string Color { get; set; }
    }
}
