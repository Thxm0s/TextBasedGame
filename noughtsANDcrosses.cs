﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextbasedGame
{
    class Xand0 : Screens
    {
        public virtual void GetGrid(string[,] Grid)
        {


            //printing the grid

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Grid[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public virtual bool game()
        {
            //rule explaining
            Console.WriteLine("Do you need to know the rules (y/n)");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                Console.WriteLine("You will go first putting X's on the grid, then the computer will go after you putting a circle. The aim of the game is to get Three crosses in a row\nGood Luck");
                Console.ReadKey();
            }





            Random rand = new Random();



            // creating the grid

            string[,] Grid = { { "-", "-", "-", },
                               { "-", "-", "-", },
                               { "-", "-", "-", } };

            int count = 0;
            bool win = false;


            GetGrid(Grid);





            while (true)
            {



                int row, column;

                Console.WriteLine("Enter row and column(i.e. 0 2):");
                var intake = Console.ReadLine();
                var arr = intake.Split(' ');
                row = int.Parse(arr[0]);
                column = int.Parse(arr[1]);



                while (true)
                {
                    if (Grid[row, column] == "0" || Grid[row, column] == "X")
                    {
                        Console.WriteLine("Choose again");
                        intake = Console.ReadLine();
                        arr = intake.Split(' ');
                        row = int.Parse(arr[0]);
                        column = int.Parse(arr[1]);

                    }
                    else
                    {
                        Grid[row, column] = "X";
                        count++;
                        break;



                    }
                }


                if (count == 9 && win == false)
                {

                    Console.WriteLine("DRAW!");
                    break;

                }







                // computer

                while (true)
                {
                    row = 0;
                    column = 0;

                    row = rand.Next(0, 3);
                    column = rand.Next(0, 3);

                    if (Grid[row, column] == "-")
                    {
                        Grid[row, column] = "0";
                        count++;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }


                if (count == 9 && win == false)
                {

                    Console.WriteLine("DRAW!");
                    break;

                }

                // win conditions

                // if crosses win
                if (
                    // horizontal wins
                    Grid[0, 0] == "X" && Grid[0, 1] == "X" && Grid[0, 2] == "X" ||
                    Grid[1, 0] == "X" && Grid[1, 1] == "X" && Grid[1, 2] == "X" ||
                    Grid[2, 0] == "X" && Grid[2, 1] == "X" && Grid[2, 2] == "X" ||
                    // vertical wins 
                    Grid[0, 0] == "X" && Grid[1, 0] == "X" && Grid[2, 0] == "X" ||
                    Grid[0, 1] == "X" && Grid[1, 1] == "X" && Grid[2, 1] == "X" ||
                    Grid[0, 2] == "X" && Grid[1, 2] == "X" && Grid[2, 2] == "X" ||
                    //diagonal wins
                    Grid[0, 0] == "X" && Grid[1, 1] == "X" && Grid[2, 2] == "X" ||
                    Grid[0, 2] == "X" && Grid[1, 1] == "X" && Grid[0, 2] == "X")

                {

                    // showing the win


                    GetGrid(Grid);


                    Console.WriteLine("Crosses win");


                    WinScreen();

                    win = true;

                    return true;

                }




                // if circles win



                else if (
                    //horizontal wins
                    Grid[0, 0] == "0" && Grid[0, 1] == "0" && Grid[0, 2] == "0" ||
                    Grid[1, 0] == "0" && Grid[1, 1] == "0" && Grid[1, 2] == "0" ||
                    Grid[2, 0] == "0" && Grid[2, 1] == "0" && Grid[2, 2] == "0" ||
                    // vertical wins 
                    Grid[0, 0] == "0" && Grid[1, 0] == "0" && Grid[2, 0] == "0" ||
                    Grid[0, 1] == "0" && Grid[1, 1] == "0" && Grid[2, 1] == "0" ||
                    Grid[0, 2] == "0" && Grid[1, 2] == "0" && Grid[2, 2] == "0" ||
                    //diagonal wins
                    Grid[0, 0] == "0" && Grid[1, 1] == "0" && Grid[2, 2] == "0" ||
                    Grid[0, 2] == "0" && Grid[1, 1] == "0" && Grid[0, 2] == "0")
                {


                    GetGrid(Grid);


                    // ComputerWin();


                    win = true;

                    break;

                }
                else if (count == 9 && win == false)
                {

                    Console.WriteLine("DRAW!");
                    break;

                }

                // if no one has won yet


                else
                {

                    GetGrid(Grid);
                    count++;
                    continue;
                }
            }



             LoseScreen();
             return false;





        }

    }
}



