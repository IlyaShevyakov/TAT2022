
namespace AvtoPark.SpareParts
{
    public class Transmission
    {
        public Transmission(string transmissionType, int numberGears, string manufacturer)
        {
            TransmissionType = transmissionType;
            NumberGears = numberGears;
            Manufacturer = Manufacturer;
        }
        public string TransmissionType { get; set; }
        public int NumberGears { get; set; }
        public string Manufacturer { get; set; }

        public override string ToString()
        {
            return $"Transmission Of Type: {TransmissionType}\nNumber Of Gears: {NumberGears}\nManufacturer: {Manufacturer}";
        }
    }
}
