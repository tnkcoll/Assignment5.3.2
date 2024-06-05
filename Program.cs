namespace Assignment5._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 21;
            Console.WriteLine(DistinctWaysToClimbStairs(steps));
        }

        static int DistinctWaysToClimbStairs(int steps)
        {
            if (steps <= 1)
            {
                return 1;
            }

            return DistinctWaysToClimbStairs(steps - 1) + DistinctWaysToClimbStairs(steps - 2);
        }
    }
}
