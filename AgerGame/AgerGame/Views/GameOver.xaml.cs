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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgerGame.Views
{
    /// <summary>
    /// Interaction logic for GameOver.xaml
    /// </summary>
    public partial class GameOver : UserControl
    {
        public GameOver()
        {
            InitializeComponent();
        }
        public GameOver(GamePlayWindow gamePlayWD)
        {
            InitializeComponent();
            btnOK.Click += (sender, e) =>
            {
                this.Visibility = Visibility.Hidden;
                gamePlayWD.Close();
            };
        }
    }
}
