
using System.Windows;
using AgerGame.ViewModel;
using AgerGame.Views;

namespace AgerGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameMenuViewModel gameMenuVM;
        public MainWindow()
        {
            InitializeComponent();
            gameMenuVM = new GameMenuViewModel();
            grMain.Children.Add(gameMenuVM.gameMenu);
        }
    }
}
