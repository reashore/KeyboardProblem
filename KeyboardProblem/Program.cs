using System;
using System.Collections.Generic;

namespace KeyboardProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static int GetKeyboardEntryTime(string keyboardInput, string keyboard)
        {
            int typingTime = 0;
            List<Tuple<int, int>> keyboardPositions = new List<Tuple<int, int>>
            {
                new Tuple<int, int>(1, 1),
                new Tuple<int, int>(1, 2),
                new Tuple<int, int>(1, 3),
                new Tuple<int, int>(2, 1),
                new Tuple<int, int>(2, 2),
                new Tuple<int, int>(2, 3),
                new Tuple<int, int>(3, 1),
                new Tuple<int, int>(3, 2),
                new Tuple<int, int>(3, 3)
            };
            Dictionary<int, Tuple<int, int>> keyboardDictionary = new Dictionary<int, Tuple<int, int>>();

            int index = 0;
            foreach (char digitChar in keyboard)
            {
                string digitString = digitChar.ToString();
                int digit = Convert.ToInt32(digitString);
                keyboardDictionary[digit] = keyboardPositions[index];
                index++;
            }

            foreach (char inputChar in keyboardInput)
            {

            }

            return 0;
        }

        private static bool IsAdjacentTo(Tuple<int, int> position1, Tuple<int, int> position2)
        {
            (int x1, int y1) = position1;
            (int x2, int y2) = position2;

            int delta1 = x1 - x2;
            int delta2 = y1 - y2;

            int distanceSquared = delta1 * delta1 + delta2 * delta2;
            bool isAdjacentTo = distanceSquared <= 2;

            return isAdjacentTo;
        }
    }
}
