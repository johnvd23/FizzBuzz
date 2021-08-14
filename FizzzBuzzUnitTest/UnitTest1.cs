using System;
using FizzBuzz;
using Xunit;

namespace FizzzBuzzUnitTest
{
    public class UnitTest1
    {

        public class FizzBuzzTest
        {
            [Fact]
            public void Test1()
            {
                _ = new FizzBuzzProcessor("1");
            }
            [Fact]
            public void Test15()
            {
                _ = new FizzBuzzProcessor("15");
            }
            [Fact]
            public void Test23()
            {
                _ = new FizzBuzzProcessor("23");
            }

            [Fact]
            public void Test3()
            {
                _ = new FizzBuzzProcessor("3");
            }
            [Fact]
            public void Test5()
            {
                _ = new FizzBuzzProcessor("5");
            }
            [Fact]
            public void TestA()
            {
                _ = new FizzBuzzProcessor("A");
            }
            [Fact]
            public void Testempty()
            {
                _ = new FizzBuzzProcessor("");
            }
        }
    }
}
