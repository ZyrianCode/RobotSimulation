using System;
using RobotSimulation.Zyrian;
using RobotSimulation.Zyrian.Entities;

namespace RobotSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation simulation = new();
            simulation.SetEntities(new Robot());
            Console.WriteLine("Введите количество итераций, необходимое для передвижений робота: ");
            var countOfIterations = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            simulation.StartSimulation(countOfIterations);
        }
    }
}
