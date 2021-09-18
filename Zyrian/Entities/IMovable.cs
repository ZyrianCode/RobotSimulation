using System;
using RobotSimulation.Zyrian.DirectionComponents;

namespace RobotSimulation.Zyrian.Entities
{
    public interface IMovable
    {
        public event EventHandler Back;
        public void Move();
        public Direction GetDirection();
    }
}
