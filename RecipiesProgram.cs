// Written by Chloe Jensrud
// 2/12/25

namespace SimulasSoup
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simulas Soup Maker!");

            var soup = Recipies.CreateSoup();
            Console.WriteLine($"\nYou made a {soup.Item3} {soup.Item2} {soup.Item3}.");
        }
    }
}
