using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spicy_Invader
{
    internal class Game
    {
        /// <summary>
        /// méthode pour commencer le jeu
        /// </summary>
        public void StartGame()
        {
            //effacer le menu
            Console.Clear();

            // redimensioner la taille de la console
            Console.SetWindowSize(90, 40);

            // afficher le vaiseau
            SpaceShip spaceShip = new SpaceShip();
            spaceShip.DrawSpaceShip();
        }
    }
}
