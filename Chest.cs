// Written by Chloe Jensrud
// 2/12/25


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulasTest
{

    enum ChestState
    {
        Open, Closed, Locked
    }
    public class Chest
    {
        private ChestState state { get; set; } = ChestState.Locked;

        public void Open()
        {
            if (state == ChestState.Closed)
            {
                state = ChestState.Open;
                Console.WriteLine("You can open the chest.");
            }
            else
            {
                Console.WriteLine("You can't open the chest in its current state.");
            }
        }
        public void Close()
        {
            if (state == ChestState.Open)
            {
                state = ChestState.Closed;
                Console.WriteLine("You closed the chest.");
            }
        }
        public void Lock()
        {
            if (state == ChestState.Closed)
            {
                state = ChestState.Locked;
                Console.WriteLine("You locked the chest.");
            }
        }
        public void Unlock()
        {
            if (state == ChestState.Locked)
            {
                state = ChestState.Closed;
                Console.WriteLine("You unlocked the chest.");
            }
            else
            { Console.WriteLine("The chest is not locked."); }
        }
    }
}
