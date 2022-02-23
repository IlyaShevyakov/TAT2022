using AvtoPark.SpareParts;
using AvtoPark.Vehicles;
using System;

namespace AvtoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine carEngine = new Engine ( 123, 1.6, "Electric", "DFK56KD4DC3" );
            Engine trucEngine = new Engine ( 205, 2.4, "Benzin", "GHJEWR42FF6" );
            Engine busEngine = new Engine ( 289, 4.8, "Dizel", "12SDFSDF89" );
            Engine scooterEngine = new Engine ( 81,  0.5, "Benzin", "LSDF34FDS04" );

            Chassi carChassis = new Chassi("7GCV", 4, 800 );
            Chassi trucChassis = new Chassi ( "HV6", 8, 20000 );
            Chassi busChassis = new Chassi ( "G9K",  6, 5000 );
            Chassi scooterChassis = new Chassi ( "34GT",  2, 250 );

            Transmission carTransmission = new Transmission ( "Robotic" , 6 , "Peugeot" );
            Transmission trucTransmission = new Transmission ( "Mechanical", 8, "MAN" );
            Transmission busTransmission = new Transmission (  "Automatic", 6, "Maz" );
            Transmission scooterTransmission = new Transmission (  "Mechanical", 4, "Yamaha" );

            Vehicle bus = new Bus(busChassis, carEngine, busTransmission, 8);
            Vehicle car = new Car(trucChassis, trucEngine, trucTransmission, "1234AB7");
            Vehicle truc = new Truc(carChassis, busEngine, carTransmission, 400);
            Vehicle scooter = new Scooter(scooterChassis, scooterEngine, scooterTransmission, 2);
            Console.WriteLine("Bus:\n" + bus.ToString() + "\n");
            Console.WriteLine("Car:\n" + car.ToString() + "\n");
            Console.WriteLine("Truc:\n" + truc.ToString() + "\n");
            Console.WriteLine("Scooter:\n" + scooter.ToString() + "\n");
        }
    }
}
