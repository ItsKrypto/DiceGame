using System.Security.Cryptography;

namespace DiceGame
{
    class Programm
    {
        static void Main(string[] args)
        {
            dicegame();
        }

        static void dicegame()
        {
            int playerwins = 0;
            int aiwins = 0;          
            Random rnd1=new Random();
            Random rnd2= new Random();


            while (true)
            {
                playerwins = 0;
                aiwins = 0;

                while (playerwins < 3 && aiwins < 3)
                {
                    Console.WriteLine("Press R to roll the dice!");
                    Console.WriteLine("------------------------");
                    int playerroll = (rnd1.Next(7));
                    int airoll = rnd2.Next(7);

                    if (Console.ReadKey(true).Key == ConsoleKey.R)
                    {
                        Console.WriteLine("You rolled " + playerroll);
                        Console.WriteLine("Computer rolled " + airoll);

                        if (playerroll > airoll)
                        {
                            Console.WriteLine("You Won!");
                            playerwins++;
                        }
                        else if (airoll > playerroll)
                        {
                            Console.WriteLine("You lost!");
                            aiwins++;
                        }
                        else
                        {
                            Console.WriteLine("You Tied!");
                        }
                        Console.WriteLine("------------------------");
                        Console.WriteLine("You: " + playerwins + " Computer: " + aiwins);
                        Console.WriteLine("------------------------");
                    }
                if (playerwins == 3)
                {
                    Console.WriteLine("Congratulation! You won the game!");
                }
                else if(aiwins == 3)
                {
                    Console.WriteLine("Better luck next time.");
                }                                                          
                }
                Console.WriteLine("Press Y to restart the game.");
                if (Console.ReadKey (true).Key != ConsoleKey.Y)
                {
                    break;
                }
            }




        }

    }
}