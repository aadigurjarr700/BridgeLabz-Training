class Solution {
    public int Divide(int dividend, int divisor) {
        if (dividend == int.MinValue && divisor == -1) {
            return int.MaxValue;
        }

        int result = dividend / divisor;

        return result;
    }
}
