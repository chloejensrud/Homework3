namespace FindMinMax1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Numbers aNumbers = new Numbers();

            int[] aNumber1 = new int[] {1, 2, 3, 4, 5};
            int[] result = aNumbers.FindMinMax(aNumber1);

            Console.WriteLine($"{result[0]}, {result[1]}");
        }
    }
}
