namespace Shuffle_an_Array
{
    public class Solution
    {
        public int[] nums;
        int[] shuffled;
        Random rnd;
   
        public Solution(int[] nums)
        {
            this.nums = nums;
            rnd= new Random(nums.Length);
        }

        public int[] Reset()
        {
            return nums;
        }

        public int[] Shuffle1()
        {
            for (int i = 0; i < shuffled.Length; i++)
            {
                int random = rnd.Next(i, shuffled.Length);
                int temp = shuffled[i];
                shuffled[i] = shuffled[random];
                shuffled[random] = temp;
            }
            return shuffled;
        }

        public int[] Shuffle2()
        {
            return nums.OrderBy(_ => rnd.Next()).ToArray();
        }
    }


    internal class Program
    {
        /// <summary>
        /// Your Solution object will be instantiated and called as such:
        /// Solution obj = new Solution(nums);
        /// int[] param_1 = obj.Reset();
        /// int[] param_2 = obj.Shuffle();
        /// </summary>
        static void Main(string[] args)
        {
            
            int[] ints = new int[] { 1, 2, 3 };

            Solution obj = new Solution(ints);

            int[] param_1 = obj.Reset();
            int[] param_2 = obj.Shuffle2();






            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nHello, World!");
        }
    }
}