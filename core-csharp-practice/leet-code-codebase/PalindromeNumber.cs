class Solution {
    public bool IsPalindrome(int n) {
        int reversed=0;
        int original=n;
        if(n<0){
            return false;
        }
        while(n!=0){
            int digits=n%10;
            reversed=reversed*10+digits;
            n=n/10;
        }
        if(reversed==original){
            return true;
        }
        return false;
    }
}