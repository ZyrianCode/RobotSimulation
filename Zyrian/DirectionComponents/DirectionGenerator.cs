using System;
using System.Collections.Generic;

namespace RobotSimulation.Zyrian.DirectionComponents
{
    public class DirectionGenerator
    {
        private readonly Random _random = new();

        private readonly List<Direction> _possibleDirections = new()
        {
            new Direction(0, "Forward"),
            new Direction(1, "Right"),
            new Direction(2, "Left"),
            new Direction(3, "Back")
        };

        public Direction GenerateDirectionFromSource() => _possibleDirections[_random.Next(_possibleDirections.Count)];
    }
}
