// Creates shapes for player, gems, and rocks

using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;


//This was Brooklyn's idea - it's in progress 
// Random randInt = new Random();
// int randIntNew = randInt.Next(0, 1800);

class Shape
{
    
    Shape circle = DrawCircle($"{randValue}", -5, 0, WHITE);
    Shape rectangle = DrawRectangle($"{randValue}", -5, 6, 4, GREEN); 
}
