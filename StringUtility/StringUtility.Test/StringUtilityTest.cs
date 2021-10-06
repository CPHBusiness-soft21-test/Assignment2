using System;
using Xunit;

namespace StringUtility.Test
{
    public class StringUtilityTest
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("aBc", "cBa")]
        [InlineData("x32h", "h23x")]
        [InlineData("!%$", "$%!")]
        [InlineData("fTE", "ETf")]
        [InlineData("FtW", "WtF")]
        [InlineData("321", "123")]
        [InlineData("racecar", "racecar")]
        [InlineData("tattarrattat", "tattarrattat")]
        public void ReverseStringTest(string input, string expected)
        {
            string result = input.ReverseString();

            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData("", "")]
        [InlineData("aBc", "ABC")]
        [InlineData("x32h", "X32H")]
        [InlineData("!%$", "!%$")]
        [InlineData("fTE", "FTE")]
        [InlineData("FtW", "FTW")]
        [InlineData("321", "321")]
        [InlineData("RAceCaR", "RACECAR")]
        [InlineData("TaTtARratTAT", "TATTARRATTAT")]
        public void CapitalizeStringTest(string input, string expected)
        {
            string result = input.CapitalizeString();

            Assert.Equal(expected, result);
        }

        
        [Theory]
        [InlineData("", "")]
        [InlineData("aBc", "abc")]
        [InlineData("X32H", "x32h")]
        [InlineData("!%$", "!%$")]
        [InlineData("fTE", "fte")]
        [InlineData("FtW", "ftw")]
        [InlineData("321", "321")]
        [InlineData("RAceCaR", "racecar")]
        [InlineData("TaTtARratTAT", "tattarrattat")]
        public void LowercaseStringTest(string input, string expected)
        {
            string result = input.LowercaseString();

            Assert.Equal(expected, result);
        }
    }
}