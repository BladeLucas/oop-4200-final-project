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
        public const int boardWidth = 8;
        public const int boardHeight = 8;
        public Grid gameboard;
        public Button[,] cells;

        public DNDGameboard(Grid container, int column,int row)
        {
            gameboard = new Grid();
            gameboard.Background = Brushes.Blue;

            for (int i = 0; i < boardWidth; i++)
            {
                gameboard.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < boardHeight; i++)
            {
                gameboard.RowDefinitions.Add(new RowDefinition());
            }

            container.Children.Add(gameboard);

            for (int y = 0;y < boardHeight;y++)
            {
                for (int x = 0; x < boardWidth;x++)
                {
                    Button newCell = new Button();
                    newCell.SetValue(Grid.ColumnProperty, x);
                    newCell.SetValue(Grid.RowProperty, y);
                    newCell.Content = x + "," + y;
                    gameboard.Children.Add(newCell);
                }
            }
        }
    }
}
