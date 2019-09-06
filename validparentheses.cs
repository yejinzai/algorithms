public class Solution {
    public bool IsValid(string s) {
        if (!string.IsNullOrEmpty(s)){
            Stack myStack = new Stack();
            List<char> open = new List<char>{'(', '{', '['};
            List<char> close = new List<char>{')', '}', ']'};
            for (int i=0; i<s.Length; i++){
                if (open.Contains(s[i])){
                    myStack.Push(s[i]);
                    continue;
                }
                else if (close.Contains(s[i])) {
                    if (myStack.Count > 0 && close.IndexOf(s[i]) == open.IndexOf((char)myStack.Peek())){
                        myStack.Pop();
                    }
                    else { myStack.Push(s[i]); } 
                    continue;
                }
            }
        
        return myStack.Count == 0 ? true : false;
            
        }
        
        return true;
    }
}
