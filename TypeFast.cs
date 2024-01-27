﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextbasedGame
{
    class TypeFast : Screens
    {
        public virtual bool game()
        {

            //rule explaining
            Console.WriteLine("Do you need to know the rules (y/n)");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                Console.WriteLine("What you will need to do is copy each word that will appear on the screen, a number of words will appear one after the other and yuo will have 30 seconds to copy all the words\nIf you get one wrong or you don't finish in 30 seconds, you lose the whole game\nGood Luck");
                Console.ReadKey();
            }

            Countdown();


            Stopwatch stopWatch = new Stopwatch(); //introducing the stopwatch
            int NumberOfQuestions = 2;


            int Score = 0;


            // reading the questions from file

            string[] Words = File.ReadAllLines("F:/Documents/TypeFastWords.txt");


            // asking each question


            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Random rnd = new Random();
                stopWatch.Start();

                int num = rnd.Next(1, Words.Length);

                string word = Words[num];




                // intaking the answer

                Console.WriteLine(word);
                string answer = Console.ReadLine();



                //chekcing if the answer is wrong


                if (answer != word)
                {
                    Console.WriteLine("INCORRECT\nYOU lose");
                    stopWatch.Stop();
                    break;
                }

                Score += 1;
            }

            Console.WriteLine(Score);
            stopWatch.Stop();





            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;


            // printing out the total time
            Console.WriteLine(ts);





            // comparing the times

            TimeSpan t1 = new TimeSpan(0, 0, 0, 30); //setting maximum time to 30 seconds



            if ((Score == NumberOfQuestions) && (TimeSpan.Compare(ts, t1) < 1))
            {
                WinScreen();
                return true;
            }



            LoseScreen();
            return false;
        }
    }
}


