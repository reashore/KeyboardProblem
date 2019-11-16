using System;
using Xunit;

namespace KeyboardProblem.Tests
{
    public class UnitTests
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            const string keyboardInput = "123456789";
            const string keyboard = "123456789";

            // Act
            int totalTypingTime = KeyboardTypingTimeProblem.GetTotalTypingTime(keyboardInput, keyboard);

            // Assert
            Assert.Equal(10, totalTypingTime);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            const string keyboardInput = "111111111";
            const string keyboard = "123456789";

            // Act
            int totalTypingTime = KeyboardTypingTimeProblem.GetTotalTypingTime(keyboardInput, keyboard);

            // Assert
            Assert.Equal(0, totalTypingTime);
        }

        [Fact]
        public void Test3()
        {
            // Arrange
            const string keyboardInput = "1111";
            const string keyboard = "123456789";

            // Act
            int totalTypingTime = KeyboardTypingTimeProblem.GetTotalTypingTime(keyboardInput, keyboard);

            // Assert
            Assert.Equal(0, totalTypingTime);
        }

        [Fact]
        public void Test4()
        {
            // Arrange
            const string keyboardInput = "1234";
            const string keyboard = "123456789";

            // Act
            int totalTypingTime = KeyboardTypingTimeProblem.GetTotalTypingTime(keyboardInput, keyboard);

            // Assert
            Assert.Equal(4, totalTypingTime);
        }

        private static void TestTotalTypingTime(string keyboardInput, string keyboard)
        {
            int totalTypingTime = KeyboardTypingTimeProblem.GetTotalTypingTime(keyboardInput, keyboard);
            string message = $"Total typing time = {totalTypingTime}";
            Console.WriteLine(message);
        }
    }
}
