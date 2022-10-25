using FluentAssertions;
using Xunit;

namespace PalindromaTeste
{
    public class PalindromaTest
    {
        [Theory]
        [InlineData(" aba",false)]
        [InlineData("aba ", false)]
        [InlineData("greetings", false)]
        [InlineData("Fish hsif", false)]
        [InlineData("ARAR", false)]        
        [InlineData("aba", true)]
        [InlineData("1000000001", true)]
        [InlineData("pennep", true)]
        [InlineData("ARARA", true)]
        public void Must_Be_Palindrome(string input, bool isPalindrome)
        {
            var result = Palindrome.IsAPalindrome(input);

            result.Should().Be(isPalindrome);
        }
    }
}