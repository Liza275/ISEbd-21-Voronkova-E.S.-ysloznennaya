using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlaneUsl
{
    public class DrawingTriangleBombs : IDrawingElements
    {
        private BombsEnum bombsEnum = BombsEnum.Two;
        public int Digit
        {
            set
            {
                switch (value)
                {
                    case 4:
                        bombsEnum = BombsEnum.Four;
                        break;
                    case 6:
                        bombsEnum = BombsEnum.Six;
                        break;
                    default:
                        bombsEnum = BombsEnum.Two;
                        break;
                }
            }
            get
            {
                return Digit;
            }
        }

        public DrawingTriangleBombs(int digit)
        {
            Digit = digit;
        }

        private void drawTwoBombs(Graphics g, Color DopColor, float _startPosX, float _startPosY)
        {
            Brush dopBrush = new SolidBrush(DopColor);
            PointF[] upRocket = new PointF[3];
            upRocket[0].X = _startPosX + 56;
            upRocket[0].Y = _startPosY - 12;
            upRocket[1].X = _startPosX + 40;
            upRocket[1].Y = _startPosY - 16;
            upRocket[2].X = _startPosX + 56;
            upRocket[2].Y = _startPosY - 20;
            g.FillPolygon(dopBrush, upRocket);
            PointF[] downRocket = new PointF[3];
            downRocket[0].X = _startPosX + 56;
            downRocket[0].Y = _startPosY + 12;
            downRocket[1].X = _startPosX + 40;
            downRocket[1].Y = _startPosY + 16;
            downRocket[2].X = _startPosX + 56;
            downRocket[2].Y = _startPosY + 20;
            g.FillPolygon(dopBrush, downRocket);
        }

        private void drawFourBombs(Graphics g, Color DopColor, float _startPosX, float _startPosY)
        {
            drawTwoBombs(g, DopColor, _startPosX, _startPosY);
            Brush dopBrush = new SolidBrush(DopColor);
            PointF[] upRocket2 = new PointF[3];
            upRocket2[0].X = _startPosX + 58;
            upRocket2[0].Y = _startPosY - 22;
            upRocket2[1].X = _startPosX + 40;
            upRocket2[1].Y = _startPosY - 26;
            upRocket2[2].X = _startPosX + 58;
            upRocket2[2].Y = _startPosY - 30;
            g.FillPolygon(dopBrush, upRocket2);
            PointF[] downRocket2 = new PointF[3];
            downRocket2[0].X = _startPosX + 58;
            downRocket2[0].Y = _startPosY + 22;
            downRocket2[1].X = _startPosX + 40;
            downRocket2[1].Y = _startPosY + 26;
            downRocket2[2].X = _startPosX + 58;
            downRocket2[2].Y = _startPosY + 30;
            g.FillPolygon(dopBrush, downRocket2);

        }

        private void drawSixBombs(Graphics g, Color DopColor, float _startPosX, float _startPosY)
        {
            drawFourBombs(g, DopColor, _startPosX, _startPosY);
            Brush dopBrush = new SolidBrush(DopColor);
            PointF[] upRocket2 = new PointF[3];
            upRocket2[0].X = _startPosX + 64;
            upRocket2[0].Y = _startPosY - 32;
            upRocket2[1].X = _startPosX + 40;
            upRocket2[1].Y = _startPosY - 36;
            upRocket2[2].X = _startPosX + 64;
            upRocket2[2].Y = _startPosY - 40;
            g.FillPolygon(dopBrush, upRocket2);
            PointF[] downRocket2 = new PointF[3];
            downRocket2[0].X = _startPosX + 64;
            downRocket2[0].Y = _startPosY + 32;
            downRocket2[1].X = _startPosX + 40;
            downRocket2[1].Y = _startPosY + 36;
            downRocket2[2].X = _startPosX + 64;
            downRocket2[2].Y = _startPosY + 40;
            g.FillPolygon(dopBrush, downRocket2);
        }
        public void drawDopElements(Graphics g, Color DopColor, float _startPosX, float _startPosY)
        {
            Brush dopBrush = new SolidBrush(DopColor);
            switch (bombsEnum)
            {
                case BombsEnum.Six:
                    drawSixBombs(g, DopColor, _startPosX, _startPosY);
                    break;
                case BombsEnum.Four:
                    drawFourBombs(g, DopColor, _startPosX, _startPosY);
                    break;
                case BombsEnum.Two:
                    drawTwoBombs(g, DopColor, _startPosX, _startPosY);
                    break;

            }
        }
    }
}
