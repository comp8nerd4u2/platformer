using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platformer
{
    /// <summary>
    /// Represents the game we want to create
    /// </summary>
    class Game
    {
        public static GameWindow gameWindow = null;

        /// <summary>
        /// Entry point to the game
        /// </summary>
        /// <param name="args">Arguments provided for the game to process</param>
        public static void main(string[] args)
        {
            // We have just been executed, so setup whatever we need to run the game
            Game.init();

        }

        /// <summary>
        /// Initializes resources for the game
        /// </summary>
        public static void init()
        {
            //TODO: Think about what we need to run the game
            // We need to initialize the game window to render game
            Game.gameWindow = new GameWindow();
        }

        
    }
}
