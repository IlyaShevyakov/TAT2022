using AvtoPark.SpareParts;

namespace AvtoPark.Vehicles
{
    class Scooter : Vehicle
    {
        public Scooter(Chassi chassi, Engine engine, Transmission transmission, int placesForLanding )
        {
            VehicleChassi = chassi;
            VehicleEngine = engine;
            VehicleTransmission = transmission;
            PlacesForLanding = placesForLanding;
        }
        public int PlacesForLanding { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"\nPlaces For Landing: {PlacesForLanding}";
        }
    }
}
