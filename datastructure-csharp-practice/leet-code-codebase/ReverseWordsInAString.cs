public class Solution {
    public string ReverseWords(string s) {
        string ans="";
        string[] arr=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        for(int i=arr.Length-1;i>=0;i--){
            ans+=arr[i];
            ans+=" ";
            
        }
        return ans.Trim();
    }
}