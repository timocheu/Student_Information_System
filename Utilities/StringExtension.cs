using System.Text.RegularExpressions;

namespace Student_Information_System.Utilities
{
    public class StringExtension
    {
        public static bool IsValidEmail(string input)
        {
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}
