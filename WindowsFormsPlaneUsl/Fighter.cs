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
        public IDrawingElements db { set; get; }
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

        public Fighter(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                isEngines = Convert.ToBoolean(strs[4]);
                isRockets = Convert.ToBoolean(strs[5]);
                switch (strs[7])
                {
                    case "TRIANGLE":
                        db = new DrawingTriangleBombs(Convert.ToInt32(strs[6]));
                        break;
                    case "ELLIPSE":
                        db = new DrawingEllipseBombs(Convert.ToInt32(strs[6]));
                        break;
                    default:
                        db = new DrawingBombsContainer(Convert.ToInt32(strs[6]));
                        break;
                }
            }
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

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{isEngines}{separator}{isRockets}{separator}{db.Digit}{separator}{db.BombsForm}";
        }

    }
}
