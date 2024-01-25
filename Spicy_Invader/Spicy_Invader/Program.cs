using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spicy_Invader
{
    internal class Program
    {   


        static void Main(string[] args)
        {
            // variable pour stocker le choix de l'utilisateur
            string _playerChoice = " ";

            // Menu
            Console.WriteLine();
            Console.WriteLine("   ***************************");
            Console.WriteLine("  |        Spicy Invader     |");
            Console.WriteLine("   ***************************\n");
            Console.WriteLine("Menu : \n");
            Console.WriteLine("1.- Jouer\n");
            Console.WriteLine("2.- Options\n");
            Console.WriteLine("3.- Highscore\n");
            Console.WriteLine("4.- A propos\n");
            Console.WriteLine("5.- Quitter\n");

            // Choix de l'utilisateur
            Console.Write("Votre choix : ");
            _playerChoice = Console.ReadLine();
            Console.WriteLine();

            // switch pour verifier le choix
            switch (_playerChoice)
            {
                case "1":
                    Play();
                    break;

                case "2":
                    Options();
                    break;

                case "3":
                    Highscore();
                    break;

                case "4":
                    About();
                    break;

                case "5":
                    Exit();
                    break;

                default:
                    Console.WriteLine("Selectionez une option de la liste");
                    break;

            }
            void Play()
            {
                Game spicyInvader = new Game();
                spicyInvader.StartGame();


            }

            void Options()
            {
                Console.Clear();
                Console.WriteLine("Options : ");
                Console.WriteLine("Son : o/n");
                _playerChoice = Console.ReadLine().ToLower();
                if (_playerChoice == "o")
                {

                }
                else if (_playerChoice == "n")
                {

                }
            }

            void Highscore()
            {

            }

            void About()
            {
                Console.Clear();
                Console.WriteLine("Spicy Invader est un jeu dans le quelle nous combatons des aliens avec notre vaisseau");
                Console.Write("Le but est de detruire les aliens avant plus avoir de vie, car nous avons que 3");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("     1.- Menu       2.- Play    ");
                _playerChoice = Console.ReadLine();

            }

            void Exit()
            {

            }


            

            // pas fermer la console
            Console.ReadLine();
        }
    }
}
