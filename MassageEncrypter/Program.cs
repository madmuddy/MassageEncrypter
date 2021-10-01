using System;
using System.Collections.Generic;


namespace MassageEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Say("1: Encrypt\n2: Decrypt\n\nSelection: ");

                    if (Convert.ToInt32(Get()) == 1)
                    {
                        Say("Enter Text to Encrypt :-\n");

                        Console.ForegroundColor = ConsoleColor.White;

                        Say("_______________________________________________________________________\n" + Encrypt(Get()) + "\n_______________________________________________________________________\n");


                        Get();
                        Say("------------------------------ New Session ------------------------------");
                    }
                    else
                    {
                        Say("Enter Text to Decrypt :-\n");

                        Console.ForegroundColor = ConsoleColor.Red;

                        Say("_______________________________________________________________________\n" + Decrypt(Get()) + "\n_______________________________________________________________________\n");

                        Get();
                        Say("------------------------------ New Session ------------------------------");
                    }
                }
                catch
                {
                    Say("\nError Occured!\n");
                }
            }
        }

        static string Encrypt(string text)
        {
            List<string> decs = new List<string>();

            string enceryptedData = "";
            char currentWord = '0';

            text = text.ToLower();

            foreach (char word in text)
            {

                switch (word)
                {
                    case 'a':
                        currentWord = 'b';
                        break;

                    case 'b':
                        currentWord = 'c';
                        break;

                    case 'c':
                        currentWord = 'd';
                        break;

                    case 'd':
                        currentWord = 'e';
                        break;

                    case 'e':
                        currentWord = 'f';
                        break;

                    case 'f':
                        currentWord = 'g';
                        break;

                    case 'g':
                        currentWord = 'h';
                        break;

                    case 'h':
                        currentWord = 'i';
                        break;

                    case 'i':
                        currentWord = 'j';
                        break;

                    case 'j':
                        currentWord = 'k';
                        break;

                    case 'k':
                        currentWord = 'l';
                        break;

                    case 'l':
                        currentWord = 'm';
                        break;

                    case 'm':
                        currentWord = 'n';
                        break;

                    case 'n':
                        currentWord = 'o';
                        break;

                    case 'o':
                        currentWord = 'p';
                        break;

                    case 'p':
                        currentWord = 'q';
                        break;

                    case 'q':
                        currentWord = 'r';
                        break;

                    case 'r':
                        currentWord = 's';
                        break;

                    case 's':
                        currentWord = 't';
                        break;

                    case 't':
                        currentWord = 'u';
                        break;

                    case 'u':
                        currentWord = 'v';
                        break;

                    case 'v':
                        currentWord = 'w';
                        break;

                    case 'w':
                        currentWord = 'x';
                        break;

                    case 'x':
                        currentWord = 'y';
                        break;

                    case 'y':
                        currentWord = 'z';
                        break;

                    case 'z':
                        currentWord = 'a';
                        break;

                    default:
                        currentWord = '0';
                        break;
                }

                decs.Add(currentWord.ToString());
            }

            foreach (string line in decs)
            {
                enceryptedData += line;
            }

            return enceryptedData;
        }

        static string Decrypt(string text)
        {
            List<string> decs = new List<string>();

            string enceryptedData = "";
            char currentWord = '0';

            text = text.ToLower();

            foreach (char word in text)
            {

                switch (word)
                {
                    case 'a':
                        currentWord = 'z';
                        break;

                    case 'b':
                        currentWord = 'a';
                        break;

                    case 'c':
                        currentWord = 'b';
                        break;

                    case 'd':
                        currentWord = 'c';
                        break;

                    case 'e':
                        currentWord = 'd';
                        break;

                    case 'f':
                        currentWord = 'e';
                        break;

                    case 'g':
                        currentWord = 'f';
                        break;

                    case 'h':
                        currentWord = 'g';
                        break;

                    case 'i':
                        currentWord = 'h';
                        break;

                    case 'j':
                        currentWord = 'i';
                        break;

                    case 'k':
                        currentWord = 'j';
                        break;

                    case 'l':
                        currentWord = 'k';
                        break;

                    case 'm':
                        currentWord = 'l';
                        break;

                    case 'n':
                        currentWord = 'm';
                        break;

                    case 'o':
                        currentWord = 'n';
                        break;

                    case 'p':
                        currentWord = 'o';
                        break;

                    case 'q':
                        currentWord = 'p';
                        break;

                    case 'r':
                        currentWord = 'q';
                        break;

                    case 's':
                        currentWord = 'r';
                        break;

                    case 't':
                        currentWord = 's';
                        break;

                    case 'u':
                        currentWord = 't';
                        break;

                    case 'v':
                        currentWord = 'u';
                        break;

                    case 'w':
                        currentWord = 'v';
                        break;

                    case 'x':
                        currentWord = 'w';
                        break;

                    case 'y':
                        currentWord = 'x';
                        break;

                    case 'z':
                        currentWord = 'y';
                        break;

                    default:
                        currentWord = ' ';
                        break;
                }

                decs.Add(currentWord.ToString());
            }

            foreach (string line in decs)
            {
                enceryptedData += line;
            }

            return enceryptedData;
        }

        static void Say(string text)
        {
            Console.WriteLine(text);
        }

        static string Get()
        {
            return Console.ReadLine();
        }
    }
}