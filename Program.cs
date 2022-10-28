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

            Raylib.InitWindow(ScreenHeight, ScreenWidth);
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Move the ball with the arrow keys!", 12, 12, 20, Color.BLACK);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}