using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextbasedGame
{
    class Player : Screens
    {
        public int space;
        public int roll;
        public string name;

        public virtual void rolldice()
        {
            Random rnd = new Random();


            roll = 0;
            for (int i = 0; i<2; i++)
            {
                int rolled = rnd.Next(1, 6);   // rolling both dices


                for (int j = 0; j < 5; j++)
                {
                    int k = rnd.Next(1, 6);

                    if (j == 4)
                    {
                        k = rolled;
                    }

                    switch (k)
                    {
                        case (1):
                            Dice1();
                            break;
                        case (2):
                            Dice2();
                            break;
                        case (3):
                            Dice3();
                            break;
                        case (4):
                            Dice4();
                            break;
                        case (5):
                            Dice5();
                            break;
                        case (6):
                            Dice6();
                            break;

                    }

                }
                roll += rolled;

                space = space + rolled;
                Console.WriteLine("Press to continue\n\n");
            
                Console.ReadKey();
                Console.Clear();
            }

          



        }

        public Player(string TempName)
        {
            name = TempName;
        }

    }



    class Spaces
    {
        public bool quicky;

        string[] Tile = { "Xand0s", "quickMaths", "TypeFast", "Backward", "Forward", "Nothing" };

        public virtual string Consequences()
        {
            Random rnd = new Random();
            int rand = rnd.Next(0, 5);

            return Tile[rand];

        }

        public virtual int MoveSpaces()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 4);

            return rand;
        }




        public virtual int IntegerValidation(string test)
        {

            while (true)
            {

                bool valid = int.TryParse(test, out int variable);

                if ((valid && variable < 5) || quicky)
                {
                    return variable;

                }
                else
                {
                    Console.WriteLine("Enter a valid answer");
                    test = Console.ReadLine();
                }
            }
        }

    }






}


