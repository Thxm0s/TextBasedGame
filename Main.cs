using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace TextbasedGame
{
    class Program : Screens
    {





        static void Main(string[] args)
        {
            // pre


            int NumberOfPeople, NumberOfSpaces;

            Spaces S = new Spaces();

            Random rnd = new Random();
            NumberOfSpaces = rnd.Next(150, 200);  // number of spaces the player has to travel



            //title screen
            Screens Screen = new Screens();
            Screen.getTitle();


            bool finished = true;


            // intro

            Console.WriteLine("You haev crash landed on a random island surrounded by far ocean. on this island is an tall middle mountain on the top you can just make out.\nYou will have to travel " + NumberOfSpaces + " spaces to reach the top\nGood Luck.");


            // getting the number of players

            Console.WriteLine("How many people have crash landed (max 4)");

            NumberOfPeople = S.IntegerValidation(Console.ReadLine());

 



            Player[] players = new Player[NumberOfPeople]; // adding players to the game giving each a class

            for (int i = 0; i < NumberOfPeople; i++)
            {
                Console.WriteLine("What is the name of survivor " + (i + 1) + ": ");
                string name = Console.ReadLine();

                players[i] = new Player(name); // adding the players


            }



            // turns
            int Turn = 0;

            /*
                        Player[] players = new Player[3]; // adding players to the game giving each a class

                        players[0] = new Player("thomas");
                        players[1] = new Player("reuban");
                        players[2] = new Player("oliver");

            */


            // Screens
            

            while (finished)        //players continously roll until finished games
            {
                int PlayerNum = 1;

                foreach (Player a in players)
                {

                    switch (PlayerNum)
                    {
                        case (1):
                            Screen.Player1();
                            break;


                        case (2):
                            Screen.Player2();
                            break;

                        case (3):
                            Screen.Player3();
                            break;

                        case (4):
                            Screen.Player4();
                            break;
                    }

                    PlayerNum++;


                    Console.WriteLine("CURRENT SPACE: " + a.space + "\n");
                    a.rolldice();


                    Console.WriteLine(a.name + ", You have rolled a " + a.roll + "\nNEW SPACE: " + a.space);




                    if (a.space >= NumberOfSpaces)
                    {
                        Console.WriteLine("\t\t\t\tCONGRATULATIONS " + a.name + "\n \n you have successfully escaped the island and now you are free, leaving all the other to stay stranded forever.");

                        finished = false;
                    }

                    else
                    {
                        string consequence = S.Consequences();
                        Console.WriteLine(consequence);
                        Console.ReadKey();






                        switch (consequence)
                        {


                            //minigame tile
                            case ("TypeFast"):
                                TypeFast T = new TypeFast();

                                if (T.game() == true)
                                {
                                    int TMove = S.MoveSpaces();

                                    a.space += TMove;

                                    Console.WriteLine("You have gained " + TMove + " spaces");
                                }

                                break;

                            case ("Xand0s"):
                                Xand0 X = new Xand0();
                                if (X.game() == true)
                                {
                                    int XMove = S.MoveSpaces();

                                    a.space += XMove;

                                    Console.WriteLine("You have gained " + XMove + " spaces");
                                }
                                break;


                            case ("quickMaths"):
                                QuickMaths M = new QuickMaths();


                                if (M.game() == true)
                                {

                                    int MMove = S.MoveSpaces();


                                    a.space += MMove;

                                    Console.WriteLine("You have gained " + MMove + " spaces");
                                }

                                break;



                            // if the person lands on a move back tile
                            case ("Backward"):

                                int Backward = S.MoveSpaces();
                                a.space -= Backward;



                                Console.WriteLine("Move back " + Backward + " Spaces");
                                Console.ReadKey();

                                break;




                            // if the person lands on a move forward tile
                            case ("Forward"):

                                int Forward = S.MoveSpaces();

                                a.space += Forward;



                                Console.WriteLine("Move FORWARD " + Forward + " Spaces");
                                Console.ReadKey();

                                break;



                            // if no consequences
                            case ("Nothing"):
                                Console.WriteLine("Nothing happened");
                                Console.ReadKey();


                                break;

                        }

                    }

                }

                /*
                                if (A.space >= NumberOfSpaces | space >= NumberOfSpaces | C.space >= NumberOfSpaces)
                                {
                                    Console.WriteLine("\t\t\t\tCONGRATULATIONS\n \n you have successfully escaped the island and now you are free, leaving all the other to stay stranded forever.");

                                    finished = false;
                                }

                  */
                Turn += 1;
            }



        }
    }

}

