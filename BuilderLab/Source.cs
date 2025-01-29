/*
* Name: [YOUR NAME HERE]
* South Hills Username: [YOUR SOUTH HILLS USERNAME HERE]
*/
using System;
using static BuilderLab.Vehicle;
using Color = BuilderLab.Vehicle.Color;

namespace BuilderLab;

public class Source
{
    /// <summary>
    /// Returns a car with a V4 engine, manual transmission, 4 wheels, 4 doors, 5 leather seats, white body, and uses gasoline.
    /// </summary>
    public Vehicle Car1()
    {
        VehicleBuilder vehicleBuilder = new VehicleBuilder();
        return vehicleBuilder.SetEngine(EngineType.V4)
            .SetTransmission(TransmissionType.Manual)
            .SetWheels(4)
            .SetDoors(4)
            .SetSeats(5)
            .SetSeatMaterial(SeatMaterial.Leather)
            .SetColor(Color.White)
            .SetFuelType(FuelType.Gasoline)
            .Build();
    }

    /// <summary>
    /// Returns a car with a V8 engine, automatic transmission, 7 vinyl seats, 4 wheels, 6 doors, blue body, uses gasoline, has a radio, and has Bluetooth.
    /// </summary>
    public Vehicle Car2()
    {
        VehicleBuilder vehicleBuilder = new VehicleBuilder();
        return vehicleBuilder.SetEngine(EngineType.V8)
            .SetTransmission(TransmissionType.Automatic)
            .SetWheels(4)
            .SetDoors(6)
            .SetSeats(7)
            .SetSeatMaterial(SeatMaterial.Vinyl)
            .SetColor(Color.Blue)
            .SetFuelType(FuelType.Gasoline)
            .SetRadio(true)
            .SetBluetooth(true)
            .Build();
    }

    /// <summary>
    /// Returns a car with a specified transmission type, two doors, four wheels, two nylon seats, white body, has a radio, and uses electric fuel.
    /// </summary>
    public Vehicle Car3(TransmissionType transmissionType)
    {
        VehicleBuilder vehicleBuilder = new VehicleBuilder();
        return vehicleBuilder.SetTransmission(transmissionType)
            .SetWheels(4)
            .SetDoors(2)
            .SetSeats(2)
            .SetSeatMaterial(SeatMaterial.Nylon)
            .SetColor(Color.White)
            .SetFuelType(FuelType.Electric)
            .SetRadio(true)
            .Build();
    }

    /// <summary>
    /// Returns a car with an automatic transmission, X doors, Y wheels, Z nylon seats, white body, has a radio, and uses electric fuel.
    /// </summary>
    public Vehicle Car4(int numOfDoors, int numOfWheels, int numOfSeats)
    {
        VehicleBuilder vehicleBuilder = new VehicleBuilder();
        return vehicleBuilder.SetTransmission(TransmissionType.Automatic)
            .SetWheels(numOfWheels)
            .SetDoors(numOfDoors)
            .SetSeats(numOfSeats)
            .SetSeatMaterial(SeatMaterial.Nylon)
            .SetColor(Color.White)
            .SetFuelType(FuelType.Electric)
            .SetRadio(true)
            .Build();
    }

    /// <summary>
    /// Returns a motorcycle with a V2 engine, manual transmission, 2 wheels, a leather seat, black body, has a radio, and uses gasoline.
    /// </summary>
    public Vehicle Motorcycle()
    {
        VehicleBuilder vehicleBuilder = new VehicleBuilder();
        return vehicleBuilder.SetEngine(EngineType.V2)
            .SetTransmission(TransmissionType.Manual)
            .SetWheels(2)
            .SetSeats(1)
            .SetSeatMaterial(SeatMaterial.Leather)
            .SetColor(Color.Black)
            .SetFuelType(FuelType.Gasoline)
            .SetRadio(true)
            .Build();
    }

    /// <summary>
    /// Returns a scooter with 2 wheels, a vinyl seat, a yellow body, uses electric fuel, has a radio, and has bluetooth
    /// </summary>
    public Vehicle Scooter()
    {
        VehicleBuilder vehicleBuilder = new VehicleBuilder();
        return vehicleBuilder.SetWheels(2)
            .SetSeatMaterial(SeatMaterial.Vinyl)
            .SetSeats(1)
            .SetColor(Color.Yellow)
            .SetFuelType(FuelType.Electric)
            .SetRadio(true)
            .SetBluetooth(true)
            .Build();
    }

    /// <summary>
    /// Returns a truck with a V16 engine, manual transmission, 2 doors, 16 wheels, diesel fuel, 2 nylon seats, red body color, and has a radio, trailer, and bluetooth.
    /// </summary>
    public Vehicle Truck1()
    {
        VehicleBuilder vehicleBuilder = new VehicleBuilder();
        return vehicleBuilder.SetEngine(EngineType.V16)
            .SetTransmission(TransmissionType.Manual)
            .SetWheels(16)
            .SetDoors(2)
            .SetSeats(2)
            .SetSeatMaterial(SeatMaterial.Nylon)
            .SetColor(Color.Red)
            .SetFuelType(FuelType.Diesel)
            .SetRadio(true)
            .SetTrailer(true)
            .SetBluetooth(true)
            .Build();
    }

    /// <summary>
    /// Returns a truck with a specified engine type, manual transmission, 4 doors, 18 wheels, diesel fuel, 3 polyester seats, green body color, and has a radio, a trailer, and mudflaps.
    /// </summary>
    public Vehicle Truck2(EngineType engineType)
    {
        VehicleBuilder vehicleBuilder = new VehicleBuilder();
        return vehicleBuilder.SetEngine(engineType)
            .SetTransmission(TransmissionType.Manual)
            .SetWheels(18)
            .SetDoors(4)
            .SetSeats(3)
            .SetSeatMaterial(SeatMaterial.Polyester)
            .SetColor(Color.Green)
            .SetFuelType(FuelType.Diesel)
            .SetRadio(true)
            .SetTrailer(true)
            .SetMudFlaps(true)
            .Build();
    }

    /// <summary>
    /// Returns a truck with an automatic transmission, 2 doors, 12 wheels, electric fuel, 3 leather seats, white body color, and has a radio and bluetooth
    /// </summary>
    public Vehicle Truck3()
    {
        VehicleBuilder vehicleBuilder = new VehicleBuilder();
        return vehicleBuilder.SetTransmission(TransmissionType.Automatic)
            .SetWheels(12)
            .SetDoors(2)
            .SetSeats(3)
            .SetSeatMaterial(SeatMaterial.Leather)
            .SetColor(Color.White)
            .SetFuelType(FuelType.Electric)
            .SetRadio(true)
            .SetBluetooth(true)
            .Build();
    }

    /// <summary>
    /// Returns a golf cart with given arguments
    /// </summary>
    public Vehicle GolfCart(int numOfWheels, int numOfSeats, Color bodyColor, FuelType fuelType)
    {
        VehicleBuilder vehicleBuilder = new VehicleBuilder();
        return vehicleBuilder.SetWheels(numOfWheels)
            .SetSeats(numOfSeats)
            .SetColor(bodyColor)
            .SetFuelType(fuelType)
            .Build();
    }
}
