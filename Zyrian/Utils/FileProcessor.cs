using System;
using System.IO;
using RobotSimulation.Zyrian.Entities;

namespace RobotSimulation.Zyrian.Utils
{
    public class FileProcessor
    {
        private readonly IMovable _movable;
        private const string Path = "RobotMoveFlow.txt";

        public FileProcessor(IMovable movable) => _movable = movable;

        public void WriteToFile()
        {
            using StreamWriter streamWriter = new(new FileStream(Path, FileMode.Append, FileAccess.Write));
            streamWriter.Write($"{DateTime.Now}, Робот движется с направлением {_movable.GetDirection()} \n");
        }
    }
}
