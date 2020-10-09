﻿using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
            game.DoToss();
            game.ChooseLetter();
            game.UserMove();
            game.ShowBoard();
        }
    }
    
}

