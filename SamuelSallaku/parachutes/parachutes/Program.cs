using System;

namespace parachutes
{   
    static class Config
    {
        public const int SCREEN_HEIGHT = 40;
        public const int SCREEN_WIDTH = 150;
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);

            Plane plane1 = new Plane(0);



            for (int i = 0; i < 100; i++)
            {
                plane1.update();
                plane1.Move();
                Thread.Sleep(100);
            }
        }
    }
    
}
