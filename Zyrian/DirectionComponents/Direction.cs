namespace RobotSimulation.Zyrian.DirectionComponents
{
    public class Direction
    {
        private int _direction;
        private readonly string _nameOfDirection;

        public Direction(int direction, string nameOfDirection)
        {
            _direction = direction;
            _nameOfDirection = nameOfDirection;
        }

        public override string ToString() => _nameOfDirection;
    }
}
