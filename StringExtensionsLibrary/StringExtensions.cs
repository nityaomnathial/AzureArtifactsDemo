namespace StringExtensionsLibrary
{
    public static class StringExtensions
    {
        // Extension method for string to check if it starts with an uppercase letter
        public static bool StartsWithUpper(this string str)
        {
            return !string.IsNullOrEmpty(str) && char.IsUpper(str[0]);
        }
    }
}
