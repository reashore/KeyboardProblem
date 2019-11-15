using System;

namespace KeyboardProblem
{
    public static class Tests
    {
        public static void RunTests()
        {
            string keyboardInput = "123456789";
            string keyboard = "123456789";
            TestTotalTypingTime(keyboardInput, keyboard);       // 10

            keyboardInput = "111111111";
            keyboard = "123456789";
            TestTotalTypingTime(keyboardInput, keyboard);       // 0

            keyboardInput = "1111";
            keyboard = "123456789";
            TestTotalTypingTime(keyboardInput, keyboard);       // 0

            keyboardInput = "1234";
            keyboard = "123456789";
            TestTotalTypingTime(keyboardInput, keyboard);       // 4
        }

        private static void TestTotalTypingTime(string keyboardInput, string keyboard)
        {
            int totalTypingTime = KeyboardTypingTimeProblem.GetTotalTypingTime(keyboardInput, keyboard);
            string message = $"Total typing time = {totalTypingTime}";
            Console.WriteLine(message);
        }
    }
}