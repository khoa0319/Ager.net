using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgerGame.Views;

namespace AgerGame.ViewModel
{
    public class GamePauseViewModel
    {
        public GamePause gamePause;
        public GamePlayWindow gamePlayWindow;
        public GamePauseViewModel(GamePlayWindow gpwd)
        {
            gamePause = new GamePause
            {
                Visibility = Visibility.Hidden
            };
            gamePlayWindow = gpwd;
            gamePause.btnResume.Click += (sender, e) =>
            {
                gamePlayWindow.gameTime.Start();
                gamePause.Visibility = Visibility.Hidden;
            };
            gamePause.btnQuit.Click += (sender, e) =>
            {
                App.Current.Shutdown();
            };
            gamePause.btnMainMenu.Click += (sender, e) =>
            {
                gamePlayWindow.gameTime.Stop();
                gamePlayWindow.Close();
            };
        }
    }
}
