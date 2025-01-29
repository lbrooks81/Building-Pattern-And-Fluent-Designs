using System;
using static BuilderLab.Vehicle;
using Color = BuilderLab.Vehicle.Color;

namespace BuilderLab;

public class VehicleBuilder
{
    //TODO: Implement your builder methods
    private Vehicle vehicle = new Vehicle();

    public VehicleBuilder SetEngine(EngineType engine)
    {
        vehicle.Engine = engine;
        return this;
    }

    public VehicleBuilder SetTransmission(TransmissionType transmission)
    {
        vehicle.Transmission = transmission;
        return this;
    }

    public VehicleBuilder SetSeatMaterial(SeatMaterial seatMaterial)
    {
        vehicle.SeatMat = seatMaterial;
        return this;
    }

    public VehicleBuilder SetFuelType(FuelType fuelType)
    {
        vehicle.VehicleFuelType = fuelType;
        return this;
    }

    public VehicleBuilder SetColor(Color color)
    {
        vehicle.BodyColor = color;
        return this;
    }

    public VehicleBuilder SetDoors(int doors)
    {
        vehicle.NumberOfDoors = doors;
        return this;
    }

    public VehicleBuilder SetWheels(int wheels)
    {
        vehicle.NumberOfWheels = wheels;
        return this;
    }

    public VehicleBuilder SetSeats(int seats)
    {
        vehicle.NumberOfSeats = seats;
        return this;
    }

    public VehicleBuilder SetRadio(bool hasRadio)
    {
        vehicle.HasRadio = hasRadio;
        return this;
    }

    public VehicleBuilder SetBluetooth(bool hasBluetooth)
    {
        vehicle.HasBluetooth = hasBluetooth;
        return this;
    }

    public VehicleBuilder SetMudFlaps(bool hasMudFlaps)
    {
        vehicle.HasMudFlaps = hasMudFlaps;
        return this;
    }

    public VehicleBuilder SetTrailer(bool hasTrailer)
    {
        vehicle.HasTrailer = hasTrailer;
        return this;
    }
    public Vehicle Build()
    {
        return vehicle;
    }
}
