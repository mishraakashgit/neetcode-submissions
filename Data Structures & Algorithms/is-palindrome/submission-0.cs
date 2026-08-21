public class Solution {
    public bool IsPalindrome(string s) {

        string input = RemoveNonAlphabetsLoop(s.ToLower());

        int i = 0;
        int j = input.Length - 1;

        while(i<j)
        {
            if(input[i++] != input[j--])
            {
                return false;
            }
        }

        return true;
    }

    public static string RemoveNonAlphabetsLoop(string input)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in input)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}