public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length)
        return false;

        int[] array1=new int[26];

        for(int i=0;i<s.Length;i++)
        {
            array1[s[i]-'a']++;
            array1[t[i]-'a']--;
        }

        for(int i =0;i<26;i++)
        {
            if(array1[i]!=0)
            return false;
        }

        return true;

    }
}
