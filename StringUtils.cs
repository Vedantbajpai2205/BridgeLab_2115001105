public class StringUtils
{
    public string Reverse(string str)
    {
        if (str == null) return null;
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public bool IsPalindrome(string str)
    {
        if (str == null) return false;
        var reversedStr = Reverse(str);
        return str.Equals(reversedStr, StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str)
    {
        if (str == null) return null;
        return str.ToUpper();
    }
}
