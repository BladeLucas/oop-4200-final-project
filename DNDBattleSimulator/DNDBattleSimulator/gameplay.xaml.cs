﻿using System;
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
        public gameplay()
        {
            InitializeComponent();
            DNDGameboard board = new DNDGameboard(layoutGrid,0,0);
        }
    }
}
