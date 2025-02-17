// Written by CHloe Jensrud
// 2/12/25


namespace SimulasTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Chest aChest = new Chest();
            while (true)
            {
                Console.WriteLine($"The chest is {aChest.State}. What do you want to do?");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "open":
                        aChest.Open(); break;
                    case "close":
                        aChest.Close(); break;
                    case "lock":
                        aChest.Lock(); break;
                    case "unlock":
                        aChest.Unlock(); break;
                    case "exit":
                        Console.WriteLine("Exiting..."); break;
                }
            }
        }
    }
}
