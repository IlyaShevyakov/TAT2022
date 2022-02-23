using AvtoPark.SpareParts;

namespace AvtoPark.Vehicles
{
    class Car : Vehicle
    {
        public Car(Chassi chassi, Engine engine, Transmission transmission, string carNumber)
        {
            VehicleChassi = chassi;
            VehicleEngine = engine;
            VehicleTransmission = transmission;
            CarNumber = carNumber;
        }

        public string CarNumber { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nCar Number: {CarNumber}";
        }
    }
}
