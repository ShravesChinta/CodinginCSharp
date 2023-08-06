public class Solution {
    public bool IsValid(string s) {
       Stack<char> stack=new Stack<char>();
       Dictionary<char, char> map=new Dictionary<char, char>();
       map[')'] = '(';
       map['}'] = '{';
       map[']'] = '[';

       for(int i=0;i<s.Length;i++)
       {
           if(map.ContainsValue(s[i]))
           {
               stack.Push(s[i]);
           }
           else
           {
               if(stack.Count==0)
               return false;

               else if(stack.Peek()!=map[s[i]])
               return false;

               stack.Pop();
           }


       } 

       if(stack.Count==0)
       return true;

       return false;
    }
}
