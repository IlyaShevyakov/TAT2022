using AvtoPark.SpareParts;

namespace AvtoPark.Vehicles
{
    public abstract class Vehicle
    {
        public Chassi VehicleChassi { get; set; }
        public Engine VehicleEngine { get; set; }
        public Transmission VehicleTransmission { get; set; }

        public override string ToString()
        {
            return $"Chassi: {VehicleChassi.ToString()}\nTransmission: {VehicleTransmission}\nEngine: {VehicleEngine}";
        }

    }
}
