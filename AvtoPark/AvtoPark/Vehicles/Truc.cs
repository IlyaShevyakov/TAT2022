using AvtoPark.SpareParts;

namespace AvtoPark.Vehicles
{
    class Truc : Vehicle
    {
        public Truc(Chassi chassi, Engine engine, Transmission transmission, int fuelTankVolume )
        {
            VehicleChassi = chassi;
            VehicleEngine = engine;
            VehicleTransmission = transmission;
            FuelTankVolume = fuelTankVolume;
        }
        public int FuelTankVolume { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nFuel Tank Volume: {FuelTankVolume}";
        }
    }
}
