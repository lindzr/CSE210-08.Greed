// Creates shapes for player, gems, and rocks

using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

class Shape 
{
    //Brooklyn can't figure this out. but I was trying to figure out a way to make it work 
    // without inheriting from the Location class. To be more simple. 
    Random random = new Random();
    Shape circle = DrawCircle($"{Random.Next(0, 1800)}", -5, 0, WHITE);
    Shape rectangle = DrawRectangle($"{randValue}", -5, 6, 4, GREEN); 
}
