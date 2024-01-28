using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextbasedGame
{
    class Screens : Spaces
    {
        public virtual void getTitle()
        {
            Console.WriteLine(@" 

                                                     
                                                     
                                                
                                                __                             __      
                                 _    __ ___   / / ____ ___   __ _  ___       / /_ ___ 
                                | |/|/ // -_) / / / __// _ \ /  ' \/ -_)     / __// _ \
                                |__,__/ \__/ /_/  \__/ \___//_/_/_/\__/      \__/ \___/
                                                       

                                     _       ___ _                     __       
                                    | |     / (_|_)  ____  ____ ______/ /___  __
                                    | | /| / / / /  / __ \/ __ `/ ___/ __/ / / /
                                    | |/ |/ / / /  / /_/ / /_/ / /  / /_/ /_/ / 
                                    |__/|__/_/_/  / .___/\__,_/_/   \__/\__, /  
                                                 /_/                   /____/   
                                         


                                          press any button to start  ");


            Console.ReadKey();
            Console.Clear();
        }




        public virtual void Countdown()
        {
            Console.WriteLine(@"
                                                
                                              _____                _       
                                             |  __ \              | |      
                                             | |__) |___  __ _  __| |_   _ 
                                             |  _  // _ \/ _` |/ _` | | | |
                                             | | \ \  __/ (_| | (_| | |_| |
                                             |_|  \_\___|\__,_|\__,_|\__, |
                                                                      __/ |
                                                                     |___/ 

        
        
                                                        ");






            Thread.Sleep(1000);
            Console.Clear();




            Console.WriteLine(@"





                                                          ____  
                                                         |___ \ 
                                                           __) |
                                                          |__ < 
                                                          ___) |
                                                         |____/ 
        
        
                                                        ");






            Thread.Sleep(1000);
            Console.Clear();



            Console.WriteLine(@"
                                                       





                                                          ___  
                                                         |__ \ 
                                                            ) |
                                                           / / 
                                                          / /_ 
                                                         |____|
       
       

        
        
                                                        ");
            Thread.Sleep(1000);
            Console.Clear();



            Console.WriteLine(@"
                     






                                                          __ 
                                                         /_ |
                                                          | |
                                                          | |
                                                          | |
                                                          |_|
     
     

     
     

       
       

        
        
                                                        ");
            Thread.Sleep(1000);

            Console.Clear();


            Console.WriteLine(@"                 
                                              




                                                     _____ ____ 
                                                    /  __//  _ \
                                                    | |  _| / \|
                                                    | |_//| \_/|
                                                    \____\\____/
            

     

     
     

       
       

        
        
                                                        ");
            Thread.Sleep(100);
            Console.Clear();

        }


        public virtual void WinScreen()
        {
            Console.WriteLine(@"
                                         __     __                   __          __  _         
                                         \ \   / /                   \ \        / / (_)        
                                          \ \_/ /    ___    _   _     \ \  /\  / /   _   _ __  
                                           \   /    / _ \  | | | |     \ \/  \/ /   | | | '_ \ 
                                            | |    | (_) | | |_| |      \  /\  /    | | | | | |
                                            |_|     \___/   \__,_|       \/  \/     |_| |_| |_|
                                                       
                                                       
                                        ");
            Console.ReadKey();
            Console.Clear();
        }

        public virtual void LoseScreen()
        {
            Console.WriteLine(@"
                                         __     __                    _                      
                                         \ \   / /                   | |                     
                                          \ \_/ /    ___    _   _    | |   ___    ___    ___ 
                                           \   /    / _ \  | | | |   | |  / _ \  / __|  / _ \
                                            | |    | (_) | | |_| |   | | | (_) | \__ \ |  __/
                                            |_|     \___/   \__,_|   |_|  \___/  |___/  \___|
                                                     
                                                     
                                        ");
            Console.ReadKey();
            Console.Clear();
        }

        public virtual void EndScreen()
        {
            Console.WriteLine(@"

                                    congrat
                                                                          ('-. .-.    ('-.           (`-.      ('-.   
                                                                         ( OO )  /   ( OO ).-.     _(OO  )_  _(  OO)  
                              ,--.   ,--. .-'),-----.  ,--. ,--.         ,--. ,--.   / . --. / ,--(_/   ,. \(,------. 
                               \  `.'  / ( OO'  .-.  ' |  | |  |         |  | |  |   | \-.  \  \   \   /(__/ |  .---' 
                             .-')     /  /   |  | |  | |  | | .-')       |   .|  | .-'-'  |  |  \   \ /   /  |  |     
                            (OO  \   /   \_) |  |\|  | |  |_|( OO )      |       |  \| |_.'  |   \   '   /, (|  '--.  
                             |   /  /\_    \ |  | |  | |  | | `-' /      |  .-.  |   |  .-.  |    \     /__) |  .--'  
                             `-./  /.__)    `'  '-'  '('  '-'(_.-'       |  | |  |   |  | |  |     \   /     |  `---. 
                               `--'           `-----'   `-----'          `--' `--'   `--' `--'      `-'      `------' 
                               ('-.     .-')                   ('-.        _ (`-.     ('-.    _ .-') _                
                             _(  OO)   ( OO ).                ( OO ).-.   ( (OO  )  _(  OO)  ( (  OO) )               
                            (,------. (_)---\_)    .-----.    / . --. /  _.`     \ (,------.  \     .'_               
                             |  .---' /    _ |    '  .--./    | \-.  \  (__...--''  |  .---'  ,`'--..._)              
                             |  |     \  :` `.    |  |('-.  .-'-'  |  |  |  /  | |  |  |      |  |  \  '              
                            (|  '--.   '..`''.)  /_) |OO  )  \| |_.'  |  |  |_.' | (|  '--.   |  |   ' |              
                             |  .--'  .-._)   \  ||  |`-'|    |  .-.  |  |  .___.'  |  .--'   |  |   / :              
                             |  `---. \       / (_'  '--'\    |  | |  |  |  |       |  `---.  |  '--'  /              
                             `------'  `-----'     `-----'    `--' `--'  `--'       `------'  `-------'               
                            ");
        }


        public virtual void ComputerWin()
        {
            Console.WriteLine(@"




                                                                      _                       _           
                                                                     | |                     (_)          
                                       ___ ___  _ __ ___  _ __  _   _| |_ ___ _ __  __      ___ _ __  ___ 
                                      / __/ _ \| '_ ` _ \| '_ \| | | | __/ _ \ '__| \ \ /\ / / | '_ \/ __|
                                     | (_| (_) | | | | | | |_) | |_| | ||  __/ |     \ V  V /| | | | \__ \
                                      \___\___/|_| |_| |_| .__/ \__,_|\__\___|_|      \_/\_/ |_|_| |_|___/
                                                         | |                                              
                                                         |_|                                              
                                    ");


            Console.ReadKey();
            Console.Clear();
        }

        public virtual void GameDraw()
        {
            Console.WriteLine(@"




                                      _____  _____       __          ___ _ 
                                     |  __ \|  __ \     /\ \        / / | |
                                     | |  | | |__) |   /  \ \  /\  / /| | |
                                     | |  | |  _  /   / /\ \ \/  \/ / | | |
                                     | |__| | | \ \  / ____ \  /\  /  |_|_|
                                     |_____/|_|  \_\/_/    \_\/  \/   (_|_)
                                       
                                       
                                         
                                    ");


            Console.ReadKey();
            Console.Clear();
        }


        public virtual void Player1()

        {
            Console.Clear();


            Console.WriteLine(@"
                                              _____  _                         __ _        _                    
                                             |  __ \| |                       /_ ( )      | |                   
                                             | |__) | | __ _ _   _  ___ _ __   | |/ ___   | |_ _   _ _ __ _ __  
                                             |  ___/| |/ _` | | | |/ _ \ '__|  | | / __|  | __| | | | '__| '_ \ 
                                             | |    | | (_| | |_| |  __/ |     | | \__ \  | |_| |_| | |  | | | |
                                             |_|    |_|\__,_|\__, |\___|_|     |_| |___/   \__|\__,_|_|  |_| |_|
                                                              __/ |                                             
                                                             |___/                                              
                                            ");
        }

        public virtual void Player2()

        {
            Console.Clear();


            Console.WriteLine(@"

                                              _____  _                         ___  _        _                    
                                             |  __ \| |                       |__ \( )      | |                   
                                             | |__) | | __ _ _   _  ___ _ __     ) |/ ___   | |_ _   _ _ __ _ __  
                                             |  ___/| |/ _` | | | |/ _ \ '__|   / /  / __|  | __| | | | '__| '_ \ 
                                             | |    | | (_| | |_| |  __/ |     / /_  \__ \  | |_| |_| | |  | | | |
                                             |_|    |_|\__,_|\__, |\___|_|    |____| |___/   \__|\__,_|_|  |_| |_|
                                                              __/ |                                               
                                                             |___/                                                

                                            
                                            ");
        }

        public virtual void Player3()

        {
            Console.Clear();


            Console.WriteLine(@"


                                              _____  _                         ____  _        _                    
                                             |  __ \| |                       |___ \( )      | |                   
                                             | |__) | | __ _ _   _  ___ _ __    __) |/ ___   | |_ _   _ _ __ _ __  
                                             |  ___/| |/ _` | | | |/ _ \ '__|  |__ <  / __|  | __| | | | '__| '_ \ 
                                             | |    | | (_| | |_| |  __/ |     ___) | \__ \  | |_| |_| | |  | | | |
                                             |_|    |_|\__,_|\__, |\___|_|    |____/  |___/   \__|\__,_|_|  |_| |_|
                                                              __/ |                                                
                                                             |___/                                                 

                                            
                                            ");
        }

        public virtual void Player4()

        {
            Console.Clear();


            Console.WriteLine(@"


                                              _____  _                         _  _   _        _                    
                                             |  __ \| |                       | || | ( )      | |                   
                                             | |__) | | __ _ _   _  ___ _ __  | || |_|/ ___   | |_ _   _ _ __ _ __  
                                             |  ___/| |/ _` | | | |/ _ \ '__| |__   _| / __|  | __| | | | '__| '_ \ 
                                             | |    | | (_| | |_| |  __/ |       | |   \__ \  | |_| |_| | |  | | | |
                                             |_|    |_|\__,_|\__, |\___|_|       |_|   |___/   \__|\__,_|_|  |_| |_|
                                                              __/ |                                                 
                                                             |___/                                                  

                                            
                                            ");
        }

        public virtual void Dice1()
        {
            Console.Clear();


            Console.WriteLine(@"

                                            -----
                                            |   |
                                            | o |
                                            |   |
                                            -----

                                            
                                            ");

            Thread.Sleep(50);
        }

        public virtual void Dice2()
        {
            Console.Clear();


            Console.WriteLine(@"

                                            -----
                                            |o  |
                                            |   |
                                            |  o|
                                            -----

                                            
                                            ");
            Thread.Sleep(50);
        }
        public virtual void Dice3()
        {
            Console.Clear();


            Console.WriteLine(@"

                                            -----
                                            |o  |
                                            | o |
                                            |  o|
                                            -----

                                            
                                            ");
            Thread.Sleep(50);
        }

        public virtual void Dice4()
        {
            Console.Clear();


            Console.WriteLine(@"

                                            -----
                                            |o o|
                                            |   |
                                            |o o|
                                            -----

                                            
                                            ");
            Thread.Sleep(50);
        }

        public virtual void Dice5()
        {
            Console.Clear();


            Console.WriteLine(@"

                                            -----
                                            |o o|
                                            | o |
                                            |o o|
                                            -----

                                            
                                            ");
            Thread.Sleep(50);
        }

        public virtual void Dice6()
        {
            Console.Clear();


            Console.WriteLine(@"

                                            -----
                                            |o o|
                                            |o o|
                                            |o o|
                                            -----

                                            
                                            ");
            Thread.Sleep(50);
        }

        public virtual void Type()
        {
            Console.WriteLine("You have landed on");
            Console.WriteLine(@"
                    ___________                   ___________                __   
                    \__    ___/__.__.______   ____\_   _____/____    _______/  |_ 
                      |    | <   |  |\____ \_/ __ \|    __) \__  \  /  ___/\   __\
                      |    |  \___  ||  |_> >  ___/|     \   / __ \_\___ \  |  |  
                      |____|  / ____||   __/ \___  >___  /  (____  /____  > |__|  
                              \/     |__|        \/    \/        \/     \/        
            ");
        }

        public virtual void Maths()
        {
            Console.WriteLine("You have landed on");
            Console.WriteLine(@"
                    ________        .__        __      _____          __  .__            
                    \_____  \  __ __|__| ____ |  | __ /     \ _____ _/  |_|  |__   ______
                     /  / \  \|  |  \  |/ ___\|  |/ //  \ /  \\__  \\   __\  |  \ /  ___/
                    /   \_/.  \  |  /  \  \___|    </    Y    \/ __ \|  | |   Y  \\___ \ 
                    \_____\ \_/____/|__|\___  >__|_ \____|__  (____  /__| |___|  /____  >
                           \__>             \/     \/       \/     \/          \/     \/ 
            ");
        }

        public virtual void Noughts()
        {
            Console.WriteLine("You have landed on");
            Console.WriteLine(@"
                             _______                      .__     __            
                             \      \   ____  __ __  ____ |  |___/  |_  ______  
                             /   |   \ /  _ \|  |  \/ ___\|  |  \   __\/  ___/  
                            /    |    (  <_> )  |  / /_/  >   Y  \  |  \___ \   
                            \____|__  /\____/|____/\___  /|___|  /__| /____  >  
                                    \/            /_____/      \/          \/   
                                 ____                                           
                                /  _ \                                          
                                >  _ </\                                        
                               /  <_\ \/                                        
                               \_____\ \                                        
                                      \/                                        
                            _________                                           
                            \_   ___ \_______  ____  ______ ______ ____   ______
                            /    \  \/\_  __ \/  _ \/  ___//  ___// __ \ /  ___/
                            \     \____|  | \(  <_> )___ \ \___ \\  ___/ \___ \ 
                             \______  /|__|   \____/____  >____  >\___  >____  >
                                    \/                  \/     \/     \/     \/ 
 
                ");
        }

        public virtual void Dash()
        {
            Console.WriteLine("You have landed on");
            Console.WriteLine(@"
                                        ___          _     
                                       /   \__ _ ___| |__  
                                      / /\ / _` / __| '_ \ 
                                     / /_// (_| \__ \ | | |
                                    /___,' \__,_|___/_| |_|                     
 
                ");

        }

        public virtual void Backward()
        {
            Console.WriteLine("You have landed on");
            Console.WriteLine(@"
                           ___            _                           _     
                          / __\ __ _  ___| | ____      ____ _ _ __ __| |___ 
                         /__\/// _` |/ __| |/ /\ \ /\ / / _` | '__/ _` / __|
                        / \/  \ (_| | (__|   <  \ V  V / (_| | | | (_| \__ \
                        \_____/\__,_|\___|_|\_\  \_/\_/ \__,_|_|  \__,_|___/                                                                     
 
                ");

        }
    }
}


