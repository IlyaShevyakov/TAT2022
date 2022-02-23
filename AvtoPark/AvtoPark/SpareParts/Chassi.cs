namespace AvtoPark.SpareParts
{
    public class Chassi
    {
        public Chassi(string numberOfWheel, int numberOfChassis, int maxLoad)
        {
            NumberOfChassis = numberOfChassis;
            NumberOfWheel = numberOfWheel;
            MaxLoad = maxLoad;
        }
        public string NumberOfWheel { get; set; }

        public int NumberOfChassis { get; set; }

        public int MaxLoad { get; set; }

        public override string ToString()
        {
            return $"Number Of Whel: {NumberOfWheel}\nNumber Of Chassis: {NumberOfChassis}\nMax Load: {MaxLoad}";
        }
    }
}
