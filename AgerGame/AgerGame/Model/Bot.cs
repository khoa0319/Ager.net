using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System;

namespace AgerGame.Model
{
    class Bot : Player
    {
        public bool IsAlive { get; set; }
        public Bot()
            :base()
        {
            WidthAndHeight = 20;
            Speed = 2;
            IsAlive = true;
            PlayerImg = new Ellipse
            {
                Width = WidthAndHeight,
                Height = WidthAndHeight,
                Fill = new ImageBrush { ImageSource = new BitmapImage(new Uri(@"pack://application:,,,/Resource/Image/AI.png")) },
                //Fill = Brushes.Red,
                StrokeThickness = 2
            };
        }
    }
}
