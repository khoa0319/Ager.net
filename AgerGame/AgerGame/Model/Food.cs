using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace AgerGame.Model
{
    public class Food
    {
        public double WidthAndHeight { get; set; }
        //position
        public double PosX { get; set; }
        public double PosY { get; set; }
        //Rect 
        public double RectX { get; set; }
        public double RectY { get; set; }
        public Ellipse Img { get; set; }        
        public Food()
        {          
            WidthAndHeight = 10;
            Img = new Ellipse
            {
                Width = WidthAndHeight,
                Height = WidthAndHeight
            };
        }
    }
}
