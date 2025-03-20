public class Solution
{
    public bool IsPalindrome(int x)
    {
        string s = x.ToString();
        for(int i  = 0; i < Math.Floor((float)s.Length / 2); i++)
        {
            if (s[i] != s[s.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}