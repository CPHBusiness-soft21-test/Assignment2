using System;

namespace StringUtility
{
    public static class StringUtility
    {
        public static string ReverseString(this string str)
        {
            string reservedString = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reservedString += str[i];
            }
            return reservedString;
        }
        public static string CapitalizeString(this string str)
        {
            string capitalizedString = "";
            foreach (char c in str)
            {
                if (c >= 'a' && c <= 'z' || (c == 'æ' || c == 'ø' || c == 'å'))
                {
                    capitalizedString += (char)(c - 32);
                }
                else
                {
                    capitalizedString += c;
                }
            }
            return capitalizedString;
        }
        public static string LowercaseString(this string str)
        {
            string lowercaseString = "";
            foreach (char c in str)
            {
                if (c >= 'A' && c <= 'Z' || (c == 'Æ' || c == 'Ø' || c == 'Å'))
                {
                    lowercaseString += (char)(c + 32);
                }
                else
                {
                    lowercaseString += c;
                }
            }
            return lowercaseString;
        }
    }
}
