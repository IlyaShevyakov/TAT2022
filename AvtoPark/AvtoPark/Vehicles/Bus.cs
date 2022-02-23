using AvtoPark.SpareParts;

namespace AvtoPark.Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(Chassi chassi, Engine engine, Transmission transmission, int numberOfDoors)
        {
            VehicleChassi = chassi;
            VehicleEngine = engine;
            VehicleTransmission = transmission;
            NumberOfDoors = numberOfDoors;

        }
        public int NumberOfDoors { get; set; }

        public override string ToString()
        {
            return base.ToString()+ $"\nNumberOfDoors: {NumberOfDoors}";
        }
    }
}
