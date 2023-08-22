using System;

namespace Class_player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(5, 5, '@');

            renderer.Draw(player.PositionX, player.PositionY, player.Symbol);
        }
    }

    class Renderer
    {
        public void Draw(int positionX, int positionY, char symbol)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(symbol);
            Console.ReadKey(true);
        }
    }

    class Player
    {
        public Player(int positionX, int positionY, char symbol)
        {
            PositionX = positionX;
            PositionY = positionY;
            Symbol = symbol;
        }

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char Symbol { get; private set; }
    }
}
