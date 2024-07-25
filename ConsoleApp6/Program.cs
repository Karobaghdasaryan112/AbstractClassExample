using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Board
    {
        public string[,] ImplementBoard;
        public string[,] CreateBoard()
        {
            ImplementBoard = new string[8, 8];

            for (int j = 0; j < 8; j++)
            {
                ImplementBoard[1, j] = "WhitePawn";
                ImplementBoard[6, j] = "BlackPawn";
            }
            for (int j = 0;j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    ImplementBoard[i, j] = "";
                    ImplementBoard[i, j] = "";
                }
            }

            ImplementBoard[0, 0] = "WhiteRook";
            ImplementBoard[0, 7] = "WhiteRook";
            ImplementBoard[7, 0] = "BlackRook";
            ImplementBoard[7, 7] = "BlackRook";


            ImplementBoard[0, 1] = "WhiteKnight";
            ImplementBoard[0, 6] = "WhiteKnight";
            ImplementBoard[7, 1] = "BlackKnight";
            ImplementBoard[7, 6] = "BlackKnight";


            ImplementBoard[0, 2] = "WhiteBishop";
            ImplementBoard[0, 5] = "WhiteBishop";
            ImplementBoard[7, 2] = "BlackBishop";
            ImplementBoard[7, 5] = "BlackBishop";


            ImplementBoard[0, 3] = "WhiteQueen";
            ImplementBoard[0, 4] = "WhiteKing";
            ImplementBoard[7, 3] = "BlackQueen";
            ImplementBoard[7, 4] = "BlackKing";

            return ImplementBoard;
        }
    }

    public abstract class Figure
    {
        public string color { get; private set; }
        protected Figure(string color)
        {
            this.color = color;
        }
        public abstract string[,] Move(int StartI, int StartJ, int EndI, int EndJ,Board board);
    }


    public class rook : Figure
    {
        private string FigureUri;
        public rook(string color) : base(color)
        {
            switch (color)
            {
                case "Black":
                    FigureUri = @"C:\Users\User\OneDrive\Рабочий стол\black\rook.png";
                    break;
                case "White":
                    FigureUri = @"C:\Users\User\OneDrive\Рабочий стол\white\rook.png";
                    break;
                default:
                    throw new ArgumentException("invalid color");
            }
        }
        public override string[,]  Move(int StartI, int StartJ, int EndI, int EndJ, Board board)
        {
            if (board.ImplementBoard[StartI,StartJ] == $"{color}Rook")
            {
                if(StartJ == EndJ)
                {
                    for(int i = StartI; i <= EndI; i++)
                    {
                        if (board.ImplementBoard[i,StartJ] != "")
                        {
                           break;
                        }
                        if(i == EndI)
                        {
                            board.ImplementBoard[i, StartJ] = $"{color}Rook";
                            board.ImplementBoard[StartI, StartJ] = "";
                        }
                    }
                }
            }
            return board.ImplementBoard;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            List<string[,]> Memory = new List<string[,]>();
            string[,] NewBoard = board.CreateBoard();

        }
    }
}
