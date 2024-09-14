using Xunit;

namespace Setup
{
    public class Jarvis
    {
        [Fact]
        public void TestAddition()
        {
            int result = StudentProject.Program.Add(2, 3); 
            Assert.Equal(5, result);        
        }

        [Fact]
        public void TestSubtraction()
        {
            int result = StudentProject.Program.Subtract(6, 3);
            Assert.Equal(3, result);
        }

        [Fact]
        public void TestMultiplication()
        {
            int result = StudentProject.Program.Multiply(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void TestDivision()
        {
            decimal result = StudentProject.Program.Divide(6, 3);
            Assert.Equal(2, result);
        }
    }
}