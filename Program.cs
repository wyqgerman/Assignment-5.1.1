namespace Assignment_5._1._1
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            int reversedHalf = 0;
            while (x > reversedHalf)
            {
                reversedHalf = reversedHalf * 10 + x % 10;
                x /= 10;
            }
            return x == reversedHalf || x == reversedHalf / 10;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(121));
            Console.WriteLine(solution.IsPalindrome(-121));
            Console.WriteLine(solution.IsPalindrome(10));
        }
    }
}
