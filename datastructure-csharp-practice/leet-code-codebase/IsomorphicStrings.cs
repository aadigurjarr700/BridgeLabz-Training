using System;
using System.Collections.Generic;

class Solution{
    public bool IsIsomorphic(string s,string t){
        Dictionary<char,char> map=new Dictionary<char,char>();
        HashSet<char> set=new HashSet<char>();
        if(s.Length!=t.Length){
            return false;
        }
        for(int i=0;i<s.Length;i++){
            char word=t[i];
            char ch=s[i];
            if(map.ContainsKey(ch)){
                if(map[ch]!=word){
                    return false;
                }
            }
            else{
                if(set.Contains(word)){
                    return false;
                }
                else{
                    set.Add(word);
                    map.Add(ch,word);
                }
            }
        }
        return true;
    }
}
