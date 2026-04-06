public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int n=digits.Length;
        for(int i=digits.Length-1;i>=0;i--)
        {
            if(digits[i]<9)
            {
                digits[i]=digits[i]+1;
                return digits;
            }
            else
            {
                digits[i]=0;
            }
        }
        int[] arr=new int[n+1];
        arr[0]=1;
        return arr;
    }
}
