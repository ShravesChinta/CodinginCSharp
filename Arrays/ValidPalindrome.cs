// Need to use System.text.RegularExpression else it will give error
//In C# the string slicing is similar to python

using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
    if(s.Length==0 || s.Length==1)
    return true;

    s=s.ToLower();
    s=Regex.Replace(s,"[^a-z0-9]", "");
    int start=0, end=s.Length-1;
    while(start<=end)
    {
        if(s[start++]!=s[end--])
        return false;
    }

    return true;
    }
}
