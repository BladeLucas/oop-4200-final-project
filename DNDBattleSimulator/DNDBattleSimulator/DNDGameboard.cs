using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace DNDBattleSimulator
{
    class DNDGameboard
    {
        public const int boardWidth = 10;
        public const int boardHeight = 10;
        public Grid gameboard;
        public Button[,] cells;

        public DNDGameboard(Grid container, int column, int row)
        {
            gameboard = new Grid();
            cells = new Button[boardWidth, boardHeight];

            for (int i = 0; i < boardWidth; i++)
            {
                gameboard.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < boardHeight; i++)
            {
                gameboard.RowDefinitions.Add(new RowDefinition());
            }

            container.Children.Add(gameboard);

            for (int y = 0; y < boardHeight; y++)
            {
                for (int x = 0; x < boardWidth; x++)
                {
                    Button newCell = new Button();
                    newCell.SetValue(Grid.ColumnProperty, x);
                    newCell.SetValue(Grid.RowProperty, y);
                    newCell.BorderBrush = Brushes.Transparent;
                    newCell.BorderThickness = new System.Windows.Thickness(0);
                    newCell.Content = x + "," + y;
                    newCell.Tag = x + "," + y;
                    cells[x, y] = newCell;
                    gameboard.Children.Add(cells[x, y]);
                }
            }
        }

        public void refreshGameBoard(Game game)
        {
            // resets board
            for (int y = 0; y < boardHeight; y++)
            {
                for (int x = 0; x < boardWidth; x++)
                {
                    cells[x, y].Content = "";
                    cells[x, y].Background = Brushes.LightGray;
                }
            }

            foreach (KeyValuePair<string, Character> entry in game.characters)
            {
                string characterName = entry.Key;
                Coordinate characterPostion = game.characterPostions[characterName];
                Button targetCell = cells[characterPostion.X, characterPostion.Y];
                targetCell.Content = characterName;

                if (characterName == game.activeCharacter)
                {
                    if (game.characters[game.activeCharacter].NPC)
                    {
                        targetCell.Background = Brushes.Red;
                    }
                    else
                    {
                        targetCell.Background = Brushes.Blue;
                    }
                }else
                {
                    targetCell.Background = Brushes.LightGray;
                }
            }

        }
    }
}
