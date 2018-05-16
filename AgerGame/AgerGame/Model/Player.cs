using System.Windows.Media;
using System.Windows.Shapes;

namespace AgerGame.Model
{
    public class Player
    {
        //public int ID { get; set; }
        public string Name { get; set; }
        public double WidthAndHeight { get; set; }
        public Ellipse PlayerImg { get; set; }
        public double PosX { get; set; }
        public double PosY { get; set; }
        public double Speed { get; set; }
        //public int Score { get; set; }
        public Player()
        {
            WidthAndHeight = 15;
            Speed = 2.2;
            PlayerImg = new Ellipse
            {
                Width = WidthAndHeight,
                Height = WidthAndHeight,
                Fill = Brushes.Aqua,
                StrokeThickness = 2
        };            
        }
    }
}
