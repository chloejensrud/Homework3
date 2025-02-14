namespace ReturnSmallerNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Compare aCompare = new Compare();

            Console.WriteLine(aCompare.SmallerNum("21", "44"));
            Console.WriteLine(aCompare.SmallerNum("1500", "1"));
        }
    }
}
