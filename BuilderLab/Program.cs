using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using static BuilderLab.Vehicle;
using static System.Formats.Asn1.AsnWriter;
using Color = BuilderLab.Vehicle.Color;

namespace BuilderLab
{
    public class Program
    {
        private const float MAX_SCORE = 10f;
        private static List<Vehicle> Vehicles { get; set; } = [];

        public static void Main()
        {
            LoadVehicles();
            float score = RunTests();

            Console.WriteLine("*** Score: " + Math.Round(score, 2) + "/" + MAX_SCORE);
        }
        private static void LoadVehicles()
        {
            if (File.Exists("inputs.json") == false)
            {
                Console.Error.WriteLine("ERROR: Could not find input file!");
                Environment.Exit(1);
            }

            Vehicles = JsonSerializer.Deserialize<List<Vehicle>>(File.ReadAllText("inputs.json"))!;
        }

        private static float RunTests()
        {
            float score = MAX_SCORE;
            float decrementAmount = MAX_SCORE / Vehicles.Count;
            Source source = new Source();

            score -= (TestProtected(source.Car1, Vehicles[0]) == false) ? decrementAmount : 0;
            score -= (TestProtected(source.Car2, Vehicles[1]) == false) ? decrementAmount : 0;

            Vehicles[2].Transmission = GenerateRandomTransmissionType();

            try
            {
                if (source.Car3(Vehicles[2].Transmission!.Value).Equals(Vehicles[2]) == false)
                {
                    score -= decrementAmount;
                    Console.Error.WriteLine("Error: Method 'Car3()' returned an incorrect object.");
                }
            }
            catch (Exception ex) when (ex is NotImplementedException == false) 
            { 
                Console.Error.WriteLine("Error: Method 'Car3()' threw an exception."); 
                score -= decrementAmount; 
            }

            Vehicles[3].NumberOfWheels = GenerateRandomNumberOfWheels();
            Vehicles[3].NumberOfDoors = GenerateRandomNumberOfDoors();
            Vehicles[3].NumberOfSeats = GenerateRandomNumberOfSeats();

            try
            {
                if (source.Car4(Vehicles[3].NumberOfDoors!.Value, Vehicles[3].NumberOfWheels!.Value, Vehicles[3].NumberOfSeats!.Value).Equals(Vehicles[3]) == false)
                {
                    score -= decrementAmount;
                    Console.Error.WriteLine("Error: Method 'Car4()' returned an incorrect object.");
                }
            }
            catch (Exception ex) when (ex is NotImplementedException == false) 
            { 
                Console.Error.WriteLine("Error: Method 'Car4()' threw an exception."); 
                score -= decrementAmount; 
            }

            score -= (TestProtected(source.Motorcycle, Vehicles[4]) == false) ? decrementAmount : 0;
            score -= (TestProtected(source.Scooter, Vehicles[5]) == false) ? decrementAmount : 0;
            score -= (TestProtected(source.Truck1, Vehicles[6]) == false) ? decrementAmount : 0;

            Vehicles[7].Engine = GenerateRandomEngineType();

            try
            {
                if (source.Truck2(Vehicles[7].Engine!.Value).Equals(Vehicles[7]) == false)
                {
                    score -= decrementAmount;
                    Console.Error.WriteLine("Error: Method 'Truck2()' returned an incorrect object.");
                }
            }
            catch (Exception ex) when (ex is NotImplementedException == false)
            {
                Console.Error.WriteLine("Error: Method 'Truck2()' threw an exception.");
                score -= decrementAmount;
            }

            score -= (TestProtected(source.Truck3, Vehicles[8]) == false) ? decrementAmount : 0;

            Vehicles[9].NumberOfWheels = GenerateRandomNumberOfWheels();
            Vehicles[9].NumberOfSeats = GenerateRandomNumberOfSeats();
            Vehicles[9].BodyColor = GenerateRandomColor();
            Vehicles[9].VehicleFuelType = GenerateRandomFuelType();

            try
            {
                if (source.GolfCart(Vehicles[9].NumberOfWheels!.Value, Vehicles[9].NumberOfSeats!.Value, Vehicles[9].BodyColor!.Value, Vehicles[9].VehicleFuelType!.Value).Equals(Vehicles[9]) == false)
                {
                    score -= decrementAmount;
                    Console.Error.WriteLine("Error: Method 'GolfCart()' returned an incorrect object.");
                }
            }
            catch (Exception ex) when (ex is NotImplementedException == false)
            {
                Console.Error.WriteLine("Error: Method 'GolfCart()' threw an exception.");
                score -= decrementAmount;
            }

            return score;
        }

        private static bool TestProtected(Func<Vehicle> vehicleGet, Vehicle testAgainst)
        {
            try
            {
                if (vehicleGet().Equals(testAgainst) == false)
                {
                    Console.Error.WriteLine("Error: Method '" + vehicleGet.Method.Name + "' returned an incorrect object.");
                    return false;
                }
            }
            catch (Exception ex) when (ex is NotImplementedException == false)
            {
                Console.Error.WriteLine("Error: Method '" + vehicleGet.Method.Name + "' threw an exception.");
                return false;
            }

            return true;
        }

        private static EngineType GenerateRandomEngineType()
        {
            return (EngineType)Random.Shared.Next(2, Enum.GetNames(typeof(EngineType)).Length - 1);
        }

        private static TransmissionType GenerateRandomTransmissionType()
        {
            return (TransmissionType)Random.Shared.Next(0, Enum.GetNames(typeof(TransmissionType)).Length - 1);
        }

        private static FuelType GenerateRandomFuelType()
        {
            return (FuelType)Random.Shared.Next(0, Enum.GetNames(typeof(FuelType)).Length - 1);
        }

        private static int GenerateRandomNumberOfDoors()
        {
            return Random.Shared.Next(1, 5) * 2;
        }

        private static int GenerateRandomNumberOfWheels()
        {
            return Random.Shared.Next(2, 10) * 2;
        }

        private static int GenerateRandomNumberOfSeats()
        {
            return Random.Shared.Next(2, 9);
        }

        private static Color GenerateRandomColor()
        {
            return (Color)Random.Shared.Next(0, Enum.GetNames(typeof(Color)).Length - 1);

        }
    }
}