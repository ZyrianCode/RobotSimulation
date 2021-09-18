using System;
using RobotSimulation.Zyrian.DirectionComponents;

namespace RobotSimulation.Zyrian.Entities
{
    public class Robot : IMovable
    {
        public event EventHandler Back;
        
        private readonly DirectionGenerator _directionGenerator = new();
 
        private Direction _direction;

        public void ChangeDirection()
        {
            _direction = _directionGenerator.GenerateDirectionFromSource();

            PrintDirection();
            CheckIfDirectionIsBack();
        }

        private void PrintDirection() => Console.WriteLine(_direction.ToString());

        private void CheckIfDirectionIsBack()
        {
            if (_direction.ToString().Equals("Back"))
            {
                Back?.Invoke(this, new EventArgs());
            }
        }

        public Direction GetDirection() => _direction;
        public void Move() => ChangeDirection();
    }
}
