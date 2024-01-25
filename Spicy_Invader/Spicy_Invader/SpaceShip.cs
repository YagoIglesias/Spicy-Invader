/// ETML
/// Auteur : Yago Iglesias Rodriguez
/// Date : 25.01.2024
/// Description : Creation de la classe veiseau de l'utilisateur

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spicy_Invader
{
    internal class SpaceShip
    {
        /// <summary>
        /// variable pour stocker la forme du veiseau
        /// </summary>
        private string _formSpaceShip = "";

        /// <summary>
        /// méthode pour dessiner le vaiseau
        /// </summary>
        public void DrawSpaceShip()
        {
            // donner la possition du curseur pour dessiner le vaiseau
            Console.CursorTop = 50;
            Console.CursorLeft = 40;

            // forme et affichage du vaiseau
            _formSpaceShip = "<*>";
            Console.WriteLine(_formSpaceShip);

        }

        public void MouvementSpaceShip()
        {
            //var pour bouger a droite
            ConsoleKey right = ConsoleKey.RightArrow;
            //var pour bouger a gauche
            ConsoleKey left = ConsoleKey.LeftArrow;

            // boucle pour bouger jusqu'a qu'il n'y aie plus de vie
            do
            {
                switch (switch_on)
                {
                    default:
                }

            } while (true);
            

        }


        /// <summary>
        /// constructeur par default
        /// </summary>
        public SpaceShip()
        {

        }



        /* /// <summary>
         /// parametre qui permet de stocker ou mettre a jour le veiseau
         /// </summary>
         public string FormSpaceShip
         {
             get 
             { 
                 return _formSpaceShip;
             }
             set 
             { 
                 _formSpaceShip = value;
             }
         }*/



    }
}
