using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AgerGame.Model;

namespace AgerGame.ViewModel
{
    public static class Util
    {
        public static readonly double WindowWidth = SystemParameters.PrimaryScreenWidth;
        public static readonly double WindowHeight = SystemParameters.PrimaryScreenHeight;
        private static readonly double SQRTO2 = Math.Sqrt(2);
        public static bool Collision(Rect r1, Rect r2)
        {
            double r1_Left = r1.Left;
            double r1_Right = r1.Right;
            double r1_Top = r1.Top;
            double r1_Bottom = r1.Bottom;
            
            double r2_Left = r2.Left;
            double r2_Right = r2.Right;
            double r2_Top = r2.Top;
            double r2_Bottom = r2.Bottom;
            return r1_Right > r2_Left && r1_Left < r2_Right && r1_Bottom > r2_Top && r1_Top < r2_Bottom ? true : false;
        }

        //public static double GetDistance(Point a, Point b) => Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));        
        // tạo Rect check va chạm
        public static Rect CreateRect(double x, double y, double m, double n)
        {
            Rect rect = new Rect(x + (m / 6), y + (n / 6), SQRTO2 * m / 2, SQRTO2 * n / 2);
            return rect;
        }
        public static Player CreatePlayer()
        {
            Player p = new Player();
            p.PlayerImg.Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Resource/Image/player.png")) };
            Canvas.SetLeft(p.PlayerImg, WindowWidth / 2); p.PosX = Canvas.GetLeft(p.PlayerImg);
            Canvas.SetTop(p.PlayerImg, WindowHeight / 2); p.PosY = Canvas.GetTop(p.PlayerImg);
            return p;
        }
        public static Food[] CreateFoods()
        {
            Food[] arr = new Food[90];
            int i;
            for (i = 0; i < 90; i++)
            {
                arr[i] = new Food(); 
            }
            return arr;
        }
    }
}
