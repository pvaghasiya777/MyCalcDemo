using MyCalcDemo;

namespace MyCalcDemoTest
{
    public class UnitTest1
    {
        [Fact]
        public void LeapYearEqual()
        {
            Assert.Equal(true, MyMath.isLeapYear(2000));
        }

        [Fact]
        public void LeapYearNotEqual()
        {
            Assert.NotEqual(false, MyMath.isLeapYear(2004));
        }

        [Theory]
        [InlineData(2001)]
        [InlineData(2002)]
        [InlineData(2003)]

        public void LeapYearInvalid(int year)
        {
            Assert.False(MyMath.isLeapYear(year));
        }

        [Theory]
        [InlineData(2000)]
        [InlineData(2004)]
        [InlineData(2008)]

        public void LeapYearvalid(int year)
        {
            Assert.True(MyMath.isLeapYear(year));
        }




        public class StringLengthTheoryTests
        {
            [Theory]
            [InlineData("Hello, world!", 13)] // Non-empty string case
            [InlineData("", 0)]               // Empty string case
            [InlineData(null, 0)]             // Null string case
            [InlineData("123456789", 9)]      //Number check
            public void TestStringLength(string input, int expectedLength)
            {
                int actualLength = MyMath.FindStringLength(input);

                Assert.Equal(expectedLength, actualLength);
            }
        }
    }
}