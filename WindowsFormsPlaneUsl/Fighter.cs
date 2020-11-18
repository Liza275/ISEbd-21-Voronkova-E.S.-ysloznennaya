using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlaneUsl
{
    public class Fighter : Warplane
    {
        private IDrawingElements db;
        public Color DopColor { private set; get; }
        public bool isEngines { private set; get; }

        public bool isRockets { private set; get; }

        public Fighter(int maxSpeed, float weight, Color mainColor, Color dopColor, bool IsEngines, bool IsRockets, int bombsNum, BombsForm bombsForm) :
                   base(maxSpeed, weight, mainColor, 113, 128)
        {
            switch (bombsForm)
            {
                case BombsForm.ELLIPSE:
                    db = new DrawingEllipseBombs(bombsNum);
                    break;
                case BombsForm.CONTAINER:
                    db = new DrawingBombsContainer(bombsNum);
                    break;
                default:
                    db = new DrawingTriangleBombs(bombsNum);
                    break;
            }
            DopColor = dopColor;
            isEngines = IsEngines;
            isRockets = IsRockets;
        }

        public override void DrawTransport(Graphics g)
        {
            Brush dopBrush = new SolidBrush(DopColor);
            if (isRockets)
            {
                db.drawDopElements(g, DopColor, _startPosX, _startPosY);
            }
            base.DrawTransport(g);
            if (isEngines)
            {
                g.FillRectangle(dopBrush, _startPosX + 104, _startPosY - 8, 9, 7);
                g.FillRectangle(dopBrush, _startPosX + 104, _startPosY + 1, 9, 7);
            }
        }
    }
}
