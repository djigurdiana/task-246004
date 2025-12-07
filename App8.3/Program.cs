using System;

namespace Task08_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого коня");
            var whiteKnightPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию черного коня");
            var blackKnightPosition = Console.ReadLine();

            if (whiteKnightPosition == blackKnightPosition)
            {
                Console.WriteLine("Кони не могут стоять на одной клетке");
                return;
            }

            int whiteKnightV, whiteKnightH;
            int blackKnightV, blackKnightH;

            if (!DecodePosition(whiteKnightPosition, out whiteKnightV, out whiteKnightH) ||
                !DecodePosition(blackKnightPosition, out blackKnightV, out blackKnightH))
            {
                Console.WriteLine("Ошибка: некорректный формат позиции");
                return;
            }

            if (IsUnderStrikeByBlackKnight(whiteKnightPosition, blackKnightPosition) ||
                IsUnderStrikeByWhiteKnight(blackKnightPosition, whiteKnightPosition))
                Console.WriteLine("Кони бьют друг друга");
            else
                Console.WriteLine("Кони не бьют друг друга");
        }

        static bool DecodePosition(string position, out int vert, out int hor)
        {
            vert = 0;
            hor = 0;


            position = position.ToLower();

            char file = position[0];
            char rank = position[1];

            if (file < 'a' || file > 'h') return false;
            if (rank < '1' || rank > '8') return false;

            vert = file - 'a' + 1;
            hor = rank - '0';

            return true;
        }


        static bool IsUnderStrikeByWhiteKnight(string position, string whiteKnightPosition)
        {
            int pV, pH, kV, kH;

            DecodePosition(position, out pV, out pH);
            DecodePosition(whiteKnightPosition, out kV, out kH);

            return IsKnightMove(kV, kH, pV, pH);
        }


        static bool IsUnderStrikeByBlackKnight(string position, string blackKnightPosition)
        {
            int pV, pH, kV, kH;

            DecodePosition(position, out pV, out pH);
            DecodePosition(blackKnightPosition, out kV, out kH);

            return IsKnightMove(kV, kH, pV, pH);
        }


        static bool IsKnightMove(int v1, int h1, int v2, int h2)
        {
            int dv = Math.Abs(v1 - v2);
            int dh = Math.Abs(h1 - h2);

            return (dv == 1 && dh == 2) || (dv == 2 && dh == 1);
        }
    }
}