class Solution{
    public bool checkPair(char ch1,char ch2){
        return((ch1=='('&&ch2==')')||(ch1=='{'&&ch2=='}')||(ch1=='['&&ch2==']'));
    }
    public bool IsValid(string s){
        Stack<char> stack=new Stack<char>();
        for(int i=0;i<s.Length;i++){
            if(s[i]=='('||s[i]=='{'||s[i]=='['){
                stack.Push(s[i]);
            }
            else{
                if(stack.Count==0){
                    return false;
                }
                else if(checkPair(stack.Peek(),s[i])){
                    stack.Pop();
                }
                else{
                    return false;
                }
            }
        }
        return stack.Count==0;
    }
}
