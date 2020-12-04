using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlaneUsl
{
    public interface IDrawingElements
    {
        int Digit { set; get; }
        void drawDopElements(Graphics g, Color DopColor, float _startPosX, float _startPosY);
    }
}
