using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TextbasedGame
{
    class Player
    {
        public int space;
        public int roll;
        public string name;

        public virtual void rolldice()
        {
            Random rnd = new Random();
            int roll1 = rnd.Next(1, 6);   // rolling both dices
            int roll2 = rnd.Next(1, 6);

            roll = roll1 + roll2;



            space += (roll1 + roll2);



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


