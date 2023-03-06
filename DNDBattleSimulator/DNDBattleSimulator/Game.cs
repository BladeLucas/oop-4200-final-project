using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DNDBattleSimulator
{
    class Game
    {
        public Dictionary<string, Character> characters;
        public Dictionary<string, Coordinate> characterPostions;
        private List<string> turnOrder;
        private int currentTurn;

        public string activeCharacter
        {
            get
            {
                return turnOrder[currentTurn];
            }
        }


        public Game()
        {
            characters = new Dictionary<string, Character>();
            characterPostions = new Dictionary<string, Coordinate>();
            turnOrder = new List<string>();
            currentTurn = 0;
        }

        public void addCharacter(Character character, Coordinate postion)
        {
            if (!characters.ContainsKey(character.Name))
            {
                characters.Add(character.Name, character);
                characterPostions.Add(character.Name, postion);
            }

            radomizeTurnOrder();
        }

        public void radomizeTurnOrder()
        {
            turnOrder.Clear();
            // add all characters to turn order
            foreach (KeyValuePair<string, Character> entry in characters)
            {
                turnOrder.Add(entry.Key);
            }

            Random rnd = new Random(); 

            // Randomize character order
            for (int i = 0; i < turnOrder.Count; i++)
            {
                String a = turnOrder[i];
                int randomIndex = rnd.Next(turnOrder.Count);
                turnOrder[i] = turnOrder[randomIndex];
                turnOrder[randomIndex] = a;
            }

        }

        public void nextTurn()
        {
            if (currentTurn == turnOrder.Count -1)
            {
                currentTurn = 0;
                radomizeTurnOrder();
            }
            else
            {
                currentTurn++;
            }
        }
    }
}
