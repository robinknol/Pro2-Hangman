using System;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGameRunning = true;

            Console.Title = "Hangman";

            // Commands
          //  string CommandQuit = {"quit", "QUIT", "Quit"};
            string CommandAlphabet = "a"; 
            int lives = 12;

            string wordone = "a";

            string[] HangingMan1 =
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                ""
            };

            string[] HangingMan2 =
            {
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "",
                "/|"
            };

            string[] HangingMan12 =
            {
                "________ ",
                "|       | ",
                "|       | ",
                "|       O ",
                "|      \\|/ ",
                "|      /\\ ",
                "|",
                " _______________ ",
                "/|              |\\ "
            };
            
            

            Console.Clear();

            // --------------------- This is the explanation of the game ---------------------

            for (var i = 12; i < HangingMan1.Length; i++) {
                Console.Write(HangingMan12[i]);
                Console.Write("\n");
            }
            
            Console.WriteLine("Hello and welcome to my hanging game.");
            Console.WriteLine("The rules are simple: Don't die");
            Console.WriteLine("");
            Console.WriteLine("Now you might be asking: 'Who the fuck is this voice in my head and how do I not die'");
            Console.WriteLine("Well I am glad you asked there are ? rules");
            Console.WriteLine("");
            Console.WriteLine("Rule 1. We are playing Hangman (If you don't know what hangman is say 1 say anything else if you know.)");
            Console.WriteLine("");

            string IKnow = Console.ReadLine();
            if (IKnow == "1") {
                Console.WriteLine("");
                Console.WriteLine("I am gonna write give you a certain amount of empty spaces you must fill it with the letters of the alphabet");
                Console.WriteLine("If you fill in the empty spaces you will get an word in the english language");
                Console.WriteLine("You have twelve (12) lives if they are all gone you will be hanged");
            }

            Console.WriteLine("");  
            Console.WriteLine("Rule 2. You are only allowed to say a letter but if think you know the word you can say it but you will lose 3 lives if you get it wrong");
            Console.WriteLine("");
            Console.WriteLine("Rule 3. If you want to give up you can say quit but you will die");
            Console.WriteLine("");
            Console.WriteLine("And just to make it fair I will always give a hint but it will disapear after your first answer");
            Console.WriteLine("Now say anything and we shall start");

            Console.ReadLine();

            // --------------------- this is the begging of the game ---------------------
            while (true) {
            Console.Clear();

                if (lives == 12) {
                    for (var i = 12; i < HangingMan1.Length; i++) {
                        Console.Write(HangingMan1[i]);
                        Console.Write("\n");
                    }
                } else if (lives == 11) {
                    for (var i = 11; i < HangingMan1.Length; i++) {
                        Console.Write(HangingMan2[i]);
                        Console.Write("\n");
                    }
                } else if (lives == 0) {
                    for (var i = 12; i < HangingMan1.Length; i++) {
                        Console.Write(HangingMan12[i]);
                        Console.Write("\n");
                    }
                }

                string input = Console.ReadLine();
                if (input.ToLower() == "quit") {
                    break;
                } else if (input != "a") {
                    lives -= 1;
                }

                string next = Console.ReadLine();
            }
        }
    }
}
