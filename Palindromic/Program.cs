using System;

class Program
{
    static string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return "";

        int start = 0, maxLength = 0;

        for (int i = 0; i < s.Length; i++)
        {
            ExpandAroundCenter(s, i, i, ref start, ref maxLength);//1

            ExpandAroundCenter(s, i, i + 1, ref start, ref maxLength);//2
        }

        return s.Substring(start, maxLength);
    }

    static void ExpandAroundCenter(string s, int left, int right, ref int start, ref int maxLength)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            int length = right - left + 1;
            if (length > maxLength)
            {
                start = left;
                maxLength = length;
            }
            left--;
            right++;
        }
    }

    static void Main()
    {
        string input = "babadacababaca";
        Console.WriteLine(LongestPalindrome(input));
    }
}