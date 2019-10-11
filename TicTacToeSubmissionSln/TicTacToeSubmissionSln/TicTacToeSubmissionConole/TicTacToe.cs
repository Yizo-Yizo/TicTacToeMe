using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;
        private char[] boardPositions = new char[9];
        char[] postions = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
        


        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }


        public void Run()
        {
            

            
           
            if (boardPositions[0] == 'X' && boardPositions[1] == 'X' && boardPositions[2] == 'X')
                return playerXhasWon;
            if (boardPositions[3] == 'X' && boardPositions[4] == 'X' && boardPositions[5] == 'X')
                return playerXhasWon;

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            Console.SetCursorPosition(2, 19);

                Console.Write("Player X");

                Console.SetCursorPosition(2, 20);

                Console.Write("Please Enter Row: ");
                var row = Console.ReadLine();

                Console.SetCursorPosition(2, 22);


                Console.Write("Please Enter Column: ");
                var column = Console.ReadLine();

                int position = (int.Parse(row) * 3) + int.Parse(column);

                boardPositions[position] = 'X';


                // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

                Console.SetCursorPosition(2, 25);

                Console.Write("Player O");

                Console.SetCursorPosition(2, 26);

                Console.Write("Please Enter Row: ");
                row = Console.ReadLine();

                Console.SetCursorPosition(2, 28);


                Console.Write("Please Enter Column: ");
                column = Console.ReadLine();

                int position2 = (int.Parse(row) * 3) + int.Parse(column);

                boardPositions[position] = 'O';




                // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
                _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);

            

        }
    }
}
