namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        public static int RemoveDuplicates(int[] nums)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!list.Contains(nums[i]))
                {
                    list.Add(nums[i]);
                    nums[list.Count - 1] = nums[i];
                }
            }

            foreach (int i in nums)
                Console.Write(i + ", ");

            return list.Count;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3, 3, 4 };
            RemoveDuplicates(nums);


            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nHello, World!");
        }
    }
}