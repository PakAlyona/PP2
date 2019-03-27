﻿
using System;
namespace Snake1
{
    public class Food : GameObject
    {
        public Food(int x, int y, char sign, ConsoleColor color) : base(x, y, sign, color)
        {
        }

        public void Generate()
        {
            Random random = new Random();
            int x = random.Next(1, 49);
            int y = random.Next(1, 27);
            body[0].x = x;
            body[0].y = y;
        }
    }

}