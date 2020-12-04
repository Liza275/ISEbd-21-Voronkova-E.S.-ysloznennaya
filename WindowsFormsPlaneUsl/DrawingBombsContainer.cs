using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlaneUsl
{
    public class DrawingBombsContainer : IDrawingElements
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

        public DrawingBombsContainer(int digit)
        {
            Digit = digit;
        }

        private void drawTwoBombs(Graphics g, Color DopColor, float _startPosX, float _startPosY)
        {
            Brush dopBrush = new SolidBrush(DopColor);
            g.FillRectangle(dopBrush, _startPosX + 40, _startPosY - 20, 16, 8);
            g.FillRectangle(dopBrush, _startPosX + 40, _startPosY + 12, 16, 8);
        }

        private void drawFourBombs(Graphics g, Color DopColor, float _startPosX, float _startPosY)
        {
            drawTwoBombs(g, DopColor, _startPosX, _startPosY);
            Brush dopBrush = new SolidBrush(DopColor);
            g.FillRectangle(dopBrush, _startPosX + 48, _startPosY - 30, 16, 8);
            g.FillRectangle(dopBrush, _startPosX + 48, _startPosY + 22, 16, 8);
        }

        private void drawSixBombs(Graphics g, Color DopColor, float _startPosX, float _startPosY)
        {
            drawFourBombs(g, DopColor, _startPosX, _startPosY);
            Brush dopBrush = new SolidBrush(DopColor);
            g.FillRectangle(dopBrush, _startPosX + 56, _startPosY - 40, 16, 8);
            g.FillRectangle(dopBrush, _startPosX + 56, _startPosY + 32, 16, 8);
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
