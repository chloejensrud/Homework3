// Written By Chloe Jensrud
// 2/16/25

namespace VinFletchersArrows
{
    public class Program
    {
        static void Main(string[] args)
        {
            Arrow arrow = GetArrow();
            Console.WriteLine($"Arrow cost: {arrow.GetCost()}");
        }
        static Arrow GetArrow()
        {
            Arrow.Arrowhead arrowhead = GetArrowheadType();
            Arrow.Fletching fletching = GetFletchingType();
            float length = GetLength();

            return new Arrow(arrowhead, fletching, length);
        }

        static Arrow.Arrowhead GetArrowheadType()
        {
            Console.WriteLine("Arrowhead type (steel, wood, obsidian): ");
            string input = Console.ReadLine();
            return input switch
            {
                "steel" => Arrow.Arrowhead.Steel,
                "wood" => Arrow.Arrowhead.Wood,
                "obsidian" => Arrow.Arrowhead.Obsidian,
                _ => throw new ArgumentException("Invalid arrowhead type")
            };
        }

        static Arrow.Fletching GetFletchingType()
        {
            Console.WriteLine("Fletching type (plastic, turkey feather, goose feather): ");
            string input = Console.ReadLine();
            return input switch
            {
                "plastic" => Arrow.Fletching.Plastic,
                "turkey feather" => Arrow.Fletching.TurkeyFeathers,
                "goose feather" => Arrow.Fletching.GooseFeathers,
                _ => throw new ArgumentException("Invalid fletching type")
            };
        }

        static float GetLength()
        {
            float length = 0;

            while (length < 60 || length > 100)
            {
                Console.WriteLine("Arrow length (between 60 and 100): ");
                length = Convert.ToSingle(Console.ReadLine());
            }
            return length;
        }
    }
}
