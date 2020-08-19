using System;
using Xunit;
using Homework;

namespace test002
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(5, 6, 11)]
        public void Test1(int num1, int num2, int num3)
        {
            var sut = new HomeWork01();
            var result = sut.Push(num1, num2);
            Assert.Equal(num3, result);
        }
    }
}
