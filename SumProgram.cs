namespace SumOfAbsoluteValue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sum aSum = new Sum();
            
            int[] test = new int[] { 2, -1, 4, 8, -10 };

            Console.WriteLine(aSum.GetAbsSum(test));
        }
    }
}
