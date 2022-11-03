using Raylib_cs;
using System.Numerics;

namespace HelloWorld
{
    static class Program
    {
        public static void Main()
        {
            var ScreenHeight = 1262;
            var ScreenWidth = 1800;

            Raylib.InitWindow(ScreenHeight, ScreenWidth, "Greed");
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {

                //some code from example program from brother Moseley that I edited for our program 
                var whichType = Random.Next(2);

                var randomY = Random.Next(-2, 2);
                var randomX = Random.Next(-2, 2);

                var position = new Vector2(randomX, 0);

                switch (whichType) {
                    case 0:
                        Console.WriteLine("Creating a rock");
                        var square = new GameSquare(Color.YELLOW, 50);
                        square.Position = position;
                        square.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(square);
                        break;
                    case 1:
                        Console.WriteLine("Creating a gem");
                        var circle = new GameCircle(Color.PINK, 50);
                        circle.Position = position;
                        circle.Velocity = new Vector2(randomX, randomY);
                        Objects.Add(circle);
                        break;
                    default:
                        break;
                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);

                foreach (var obj in Objects) {
                    obj.Draw();
                }

                Raylib.EndDrawing();
            }

            foreach (var obj in Objects) {
                    obj.Move();
                }

            Raylib.CloseWindow();
        }
    }
}