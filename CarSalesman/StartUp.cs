using System;
using System.Collections.Generic;

namespace CarSalesman;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Car> cars = new();
        List<Engine> engines = new();

        int countEngines = int.Parse(Console.ReadLine());

        for (int i = 0; i < countEngines; i++)
        {
            string[] engineProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Engine engine = CreateEngine(engineProperties);

            engines.Add(engine);
        }

        int countCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < countCars; i++)
        {
            string[] carProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Car car = CreateCar(carProperties, engines);

            cars.Add(car);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }

    static Engine CreateEngine(string[] enginePropeties)
    {
        Engine engine = new(enginePropeties[0], int.Parse(enginePropeties[1]));

        if (enginePropeties.Length > 2)
        {
            int displacement;

            bool isDigit = int.TryParse(enginePropeties[2], out displacement);

            if (isDigit)
            {
                engine.Displacement = displacement;
            }
            else
            {
                engine.Efficiency = enginePropeties[2];
            }

            if (enginePropeties.Length > 3)
            {
                engine.Efficiency = enginePropeties[3];
            }
        }

        return engine;
    }

    static Car CreateCar(string[] carProperties, List<Engine> engines)
    {
        Engine engine = engines.Find(x => x.Model == carProperties[1]);

        Car car = new(carProperties[0], engine);

        if (carProperties.Length > 2)
        {
            int weight;

            bool isDigit = int.TryParse(carProperties[2], out weight);

            if (isDigit)
            {
                car.Weight = weight;
            }
            else
            {
                car.Color = carProperties[2];
            }

            if (carProperties.Length > 3)
            {
                car.Color = carProperties[3];
            }
        }

        return car;
    }
}