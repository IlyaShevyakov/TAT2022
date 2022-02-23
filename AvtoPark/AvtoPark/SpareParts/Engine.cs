namespace AvtoPark.SpareParts
{
    public class Engine
    {
        public Engine(int power, double volume, string type, string serialNumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }
        public int Power { get; set; }
        public double Volume { get; set; }
        public string Type { get; set; }
        public string SerialNumber { get; set; }

        public override string ToString()
        {
            return $"Power: {Power}\nVolume: {Volume}\nType: {Type}\nSerial Of Number: {SerialNumber}";
        }
    }
}
