using System;

class Vehicle
{
    public string VehicleName;
    public string VehicleId;

    public void ShowInfo()
    {
        Console.WriteLine($" Vehicle Name : {VehicleName}, VehicleId: {VehicleId}");
    }
    public void Status()
    {
        Console.WriteLine("--- THIS A VEHICLE ---");
    }
}
class MotorBike : Vehicle { }
class Truck : Vehicle { }
class Car : Vehicle { }
class Saloon : Car { }
class MPV : Car { }

class Program
{
    static void Main(string[] args)
    {
        Vehicle motorbike = new MotorBike();
        motorbike.VehicleName = "TESLA";
        motorbike.VehicleId = "KP-002";
        motorbike.ShowInfo();
        motorbike.Status();

        Vehicle truck = new Truck();
        truck.VehicleName = "TOYOTA";
        truck.VehicleId = "RWS-0365";
        truck.ShowInfo();
        truck.Status();

        Vehicle mpv = new MPV();
        mpv.VehicleName = "KOENENSIGG-JESCO";
        mpv.VehicleId = "AAA-008";
        mpv.ShowInfo();
        mpv.Status();

    }
        
}
