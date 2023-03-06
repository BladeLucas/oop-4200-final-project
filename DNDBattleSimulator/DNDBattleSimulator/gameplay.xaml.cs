using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DNDBattleSimulator
{
    /// <summary>
    /// Interaction logic for gameplay.xaml
    /// </summary>
    public partial class gameplay : Window
    {
        Game mainGame;
        DNDGameboard board;
        public gameplay()
        {
            InitializeComponent();
            board = new DNDGameboard(layoutGrid,0,0);
            mainGame = new Game();
            mainGame.addCharacter(new Character("player-1", false),new Coordinate(0,0));
            mainGame.addCharacter(new Character("player-2", false), new Coordinate(1, 0));
            mainGame.addCharacter(new Character("player-3", false), new Coordinate(2, 0));
            mainGame.addCharacter(new Character("mob-1", true), new Coordinate(0, 7));
            mainGame.addCharacter(new Character("mob-2", true), new Coordinate(1, 7));
            mainGame.addCharacter(new Character("mob-3", true), new Coordinate(2, 7));

        }

        private void nextTurn_Click(object sender, RoutedEventArgs e)
        {
            mainGame.nextTurn();
            board.refreshGameBoard(mainGame);
        }
    }
}
