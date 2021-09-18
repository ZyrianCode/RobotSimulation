using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotSimulation.Zyrian.Entities;
using RobotSimulation.Zyrian.Utils;

namespace RobotSimulation.Zyrian
{
    public class Simulation
    {
        private IMovable _movable;

        private int _iteration = default;

        public void SetEntities(IMovable movable) => _movable = movable;

        public void StartSimulation(int iterationsCount)
        {
            _movable.Back += OnBack;

            while (_iteration != iterationsCount)
            {
                _movable.Move();
                _iteration++;
            }
        }

        private void OnBack(object sender, EventArgs eventArgs)
        {
            var fileProcessor = new FileProcessor(_movable);
            fileProcessor.WriteToFile();
        }
    }
}
