using System;

namespace Adventure_Game_
{
    public static class Game
    {
        //charcter name
        static string CharacterName = "";

        //print out game title and overview
        public static void StartGame()
        {
            Console.WriteLine("Adventure Game!");
            Console.WriteLine("Welcome the my first game!");
            NameCharacter();
        }

        //ask player for name and svae it
        static void NameCharacter()
        {
            Console.Write("Please Enter Your Name: ");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Welcome the my first game " + CharacterName + "!");
        }
        
    }

    class Item
    {

    }

    class Program
    {
        static void Main()
        {
            //Console title
            Console.Title = "Adventure Game!";

            Game.StartGame();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}  
