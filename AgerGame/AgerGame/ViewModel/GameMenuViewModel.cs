using System;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgerGame.Views;
using static System.Net.Mime.MediaTypeNames;
using AgerGame.ViewModel;
using System.Windows.Media;
using System.Windows.Controls;

namespace AgerGame.ViewModel
{
    public class GameMenuViewModel
    {
        private bool IsPlaying = true;
        public GameMenu gameMenu;
        public GamePlayWindow gamePlayWindow;
        MediaPlayer mp3 = new MediaPlayer();
        public GameMenuViewModel()
        {
            gameMenu = new GameMenu
            {
                Visibility = Visibility.Visible
            };
            mp3.Open(new Uri(@"Bgm.mp3", UriKind.RelativeOrAbsolute));
            mp3.Play();
            gameMenu.btnQuit.Click += (sender, e) =>
            {
                App.Current.Shutdown();
            };
            gameMenu.btnPlay.Click += (sender, e) =>
            {
                gamePlayWindow = new GamePlayWindow
                {
                    t1 = DateTime.Now
                };
                gamePlayWindow.ShowDialog();
            };
            gameMenu.btnMusic.Click += (sender, e) =>
            {
                if (!IsPlaying)
                {
                    mp3.Play();
                    IsPlaying = true;
                    gameMenu.btnMusic.Content = "Music on";
                 
                }
                else
                {
                    mp3.Pause();
                    IsPlaying = false;
                    gameMenu.btnMusic.Content = "Music off";
                }
            };
        }
    }

}

