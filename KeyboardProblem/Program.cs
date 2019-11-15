using System.Collections.Generic;
using static System.Console;

namespace KeyboardProblem
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            const string keyboardInput = "123456789";
            const string keyboard = "123456789";

            int totalTypingTime = GetTotalTypingTime(keyboardInput, keyboard);
            string message = $"Total typing time = {totalTypingTime}";
            WriteLine(message);

            ReadKey();
        }

        private static int GetTotalTypingTime(string keyboardInput, string keyboard)
        {
            int totalTypingTime = 0;
            List<Position> keyboardPositions = new List<Position>
            {
                new Position(1, 1),
                new Position(1, 2),
                new Position(1, 3),
                new Position(2, 1),
                new Position(2, 2),
                new Position(2, 3),
                new Position(3, 1),
                new Position(3, 2),
                new Position(3, 3)
            };
            Dictionary<string, Position> keyboardDictionary = new Dictionary<string, Position>();

            int index = 0;
            foreach (char digitChar in keyboard)
            {
                string digitString = digitChar.ToString();
                keyboardDictionary[digitString] = keyboardPositions[index];
                index++;
            }

            char previousInputChar = keyboardInput[0];
            string previousInputString = previousInputChar.ToString();
            Position previousPosition = keyboardDictionary[previousInputString];

            for (int n = 1; n < 9; n++)
            {
                char nextInputChar = keyboardInput[n];
                string nextInputString = nextInputChar.ToString();
                Position nextPosition = keyboardDictionary[nextInputString];

                totalTypingTime += GetTypingTime(previousPosition, nextPosition);
                previousPosition = nextPosition;
            }

            return totalTypingTime;
        }

        private static int GetTypingTime(Position position1, Position position2)
        {
            int x1 = position1.X;
            int y1 = position1.Y;

            int x2 = position2.X;
            int y2 = position2.Y;

            int delta1 = x1 - x2;
            int delta2 = y1 - y2;

            if (delta1 == 0 && delta2 == 0)
            {
                return 0;
            }

            int distanceSquared = delta1 * delta1 + delta2 * delta2;
            bool isAdjacentTo = distanceSquared <= 2;

            return isAdjacentTo ? 1 : 2;
        }
    }

    public struct Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
