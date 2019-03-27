using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace Snake1
{
    public class Game
    {
        List<GameObject> g_objects;
        public long m,d;
        public bool isAlive;
        public Snake snake;
        public Food food;
        public Wall wall;

        public Game()
        {
            g_objects = new List<GameObject>();
            snake = new Snake(20, 10, 'o', ConsoleColor.Cyan);
            food = new Food(0, 0, '*', ConsoleColor.White);
            wall = new Wall('#', ConsoleColor.Green);
            wall.LoadLevel();
            while (food.IsCollisionWithObject(snake) || food.IsCollisionWithObject(wall))
                food.Generate();

            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);

            isAlive = true;
        }

        public void Start()
        {
            Load();
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            Thread thread = new Thread(MoveSnake);
            thread.Start();

            while (isAlive && keyInfo.Key != ConsoleKey.Escape)
            {
                keyInfo = Console.ReadKey();
                snake.ChangeDirection(keyInfo);
            }
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("Game over, loshara");
            Console.ReadKey();
        }

        public void MoveSnake()
        {
            while (isAlive)
            {
                snake.Move();
                
                if (snake.IsCollisionWithObject(food))
                {
                    snake.body.Add(new Point(0, 0));
                    while (food.IsCollisionWithObject(snake) || food.IsCollisionWithObject(wall))
                        food.Generate();
                    if (snake.body.Count % 5 == 0)
                        wall.NextLevel();
                }
                if (snake.IsCollisionWithObject(wall))
                {
                    isAlive = false;
                    Save();
                }
                Draw();
                Thread.Sleep(200);
            }
            
        }
        public void Draw()
        {
            Console.Clear();
            
            foreach (GameObject g in g_objects)
                g.Draw();
            m = snake.body.Count;
            Console.SetCursorPosition(50, 15);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("                            Previous result: ");
            Console.Write(d);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(50, 17);
            Console.Write("                            Score: ");
            Console.Write(m);
        }

        public void Save()
        {
            FileStream fs = new FileStream("Score.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer serial = new XmlSerializer(typeof(long));
            serial.Serialize(fs, m);
            
            fs.Close();
        }

        public void Load()
        {
            FileStream ds = new FileStream("Score.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer deserial = new XmlSerializer(typeof(long));
            d = (long)deserial.Deserialize(ds);
            ds.Close();

        }
        public void ShowMenu()
        {

        }
        public void DrawResult()
        {
        
        }
    }
} 