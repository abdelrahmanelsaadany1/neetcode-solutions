namespace HasDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public class Solution
        {
            public bool hasDuplicate(int[] nums)
            {
                HashSet<int> set = new HashSet<int>();
                foreach (var num in nums)
                {
                    if (!set.Add(num))
                    {
                        return true;

                    }

                }
                return false;

            }
        }
    }
}
