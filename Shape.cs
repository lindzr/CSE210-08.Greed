// Creates shapes for player, gems, and rocks

using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

class Shape 
{
    int randValue = GetRandomValue(0, 1800);
    Shape circle = DrawCircle($"{randValue}", -5, 0, WHITE);
    Shape rectangle = DrawRectangle($"{randValue}", -5, 6, 4, GREEN); 
}
