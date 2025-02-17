namespace MultiplyingValuesBySum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Multiplier aMultiplier = new Multiplier();

            int[] test1 = { 2, 3, 1, 0 };
            int[] test2 = { 4, 1, 1 };

            Console.WriteLine(string.Join(", ", aMultiplier.MultiplyLength(test1)));
            Console.WriteLine(string.Join(", ", aMultiplier.MultiplyLength(test2)));
        }
    }
}
