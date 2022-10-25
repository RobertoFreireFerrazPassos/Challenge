namespace PalindromaTeste
{
    public static class ReverseString
    {
        public static string Reverse(string input)
        {
            string output = "";

            foreach (char character in input)
            {
                output = character + output;
            }
            return output;
        }
    }
}
