using RogaRoga.Objects;

namespace RogaRoga.Baze
{
    public abstract class Game
    {
        // Задаем базовые параметры карты и упаковываем их в массив
        // Двухмерный массив – это прямоугольник (2д фигура)
        static int MapWidth = 60;
        static int MapHeight = 40;
        string[,] mapData = new string[MapWidth, MapHeight];
        Random random = new Random();

    }
}