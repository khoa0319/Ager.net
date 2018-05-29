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
            IsAlive = true;
        }
    }
}
