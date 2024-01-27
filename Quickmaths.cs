using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;




namespace TextbasedGame
{
    class QuickMaths : Screens
    {
        public virtual bool game()
        {


            quicky = true;

            //rule explaining
            Console.WriteLine("Do you need to know the rules (y/n)");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                Console.WriteLine("What you will need to do is solve a number of simple sums in a time of 30 seconds\nIf you get one wrong or you don't finish in 30 seconds, you lose the whole game\nGood Luck");
                Console.ReadKey();
            }


            Countdown();


            Stopwatch stopWatch = new Stopwatch(); //introducing the stopwatch
            int NumberOfQuestions = 2;


            int Score = 0;




            // asking each question


            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Random rnd = new Random();
                stopWatch.Start();

                int num1 = rnd.Next(1, 50);
                int num2 = rnd.Next(1, 50);

                int correct = num1 + num2;

                Console.WriteLine(num1 + "+" + num2);


                int answer = IntegerValidation(Console.ReadLine());


                //chekcing if the answer is wrong


                if (answer != correct)
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
                quicky = false;
                return true;
            }


            LoseScreen();
            quicky = false;
            return false;
        }


    }
}



