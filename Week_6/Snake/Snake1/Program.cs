
using System;

namespace Snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(50, 30);
            //Console.SetBufferSize(50, 30);
            Console.CursorVisible = false;
            Game game = new Game();
            game.Start();
        }
    }
}