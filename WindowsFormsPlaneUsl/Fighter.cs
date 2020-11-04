using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlaneUsl
{
    public class Fighter
    {
        private DrawingBombs db;
        protected float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        protected float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }

        public float Weight { private set; get; }

        public Color MainColor { private set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureHeight = height;
            _pictureWidth = width;
        }
        public Color DopColor { private set; get; }

        protected readonly int warplaneWidth = 113;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        protected readonly int warplaneHeight = 128;

        public bool isEngines { private set; get; }

        public bool isRockets { private set; get; }
        public Fighter(int maxSpeed, float weight, Color mainColor, Color dopColor, bool IsEngines, bool IsRockets, int bombs)
        {
            db = new DrawingBombs(bombs);
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            isEngines = IsEngines;
            isRockets = IsRockets;
        }

        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - warplaneWidth)
                    {
                        _startPosX += step;

                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - warplaneHeight / 2 - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + warplaneHeight / 2 + step < _pictureHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public void DrawTransport(Graphics g)
        {
            Brush dopBrush = new SolidBrush(DopColor);
            if (isRockets)
            {
                //PointF[] upRocket = new PointF[3];
                //upRocket[0].X = _startPosX + 56;
                //upRocket[0].Y = _startPosY - 12;
                //upRocket[1].X = _startPosX + 40;
                //upRocket[1].Y = _startPosY - 16;
                //upRocket[2].X = _startPosX + 56;
                //upRocket[2].Y = _startPosY - 20;
                //g.FillPolygon(dopBrush, upRocket);
                //PointF[] downRocket = new PointF[3];
                //downRocket[0].X = _startPosX + 56;
                //downRocket[0].Y = _startPosY + 12;
                //downRocket[1].X = _startPosX + 40;
                //downRocket[1].Y = _startPosY + 16;
                //downRocket[2].X = _startPosX + 56;
                //downRocket[2].Y = _startPosY + 20;
                //g.FillPolygon(dopBrush, downRocket);

                db.drawBombs(g, DopColor, _startPosX, _startPosY);
            }
            Brush mainBrush = new SolidBrush(MainColor);
            PointF[] nose = new PointF[3];
            nose[0].X = _startPosX;
            nose[0].Y = _startPosY;
            nose[1].X = _startPosX + 24;
            nose[1].Y = _startPosY - 8;
            nose[2].X = _startPosX + 24;
            nose[2].Y = _startPosY + 8;
            g.FillPolygon(mainBrush, nose);
            g.FillRectangle(mainBrush, _startPosX + 24, _startPosY - 8, 80, 16);
            PointF[] upWing = new PointF[3];
            upWing[0].X = _startPosX + 46;
            upWing[0].Y = _startPosY - 8;
            upWing[1].X = _startPosX + 78;
            upWing[1].Y = _startPosY - 64;
            upWing[2].X = _startPosX + 78;
            upWing[2].Y = _startPosY - 8;
            g.FillPolygon(mainBrush, upWing);
            PointF[] downWing = new PointF[3];
            downWing[0].X = _startPosX + 46;
            downWing[0].Y = _startPosY + 8;
            downWing[1].X = _startPosX + 78;
            downWing[1].Y = _startPosY + 64;
            downWing[2].X = _startPosX + 78;
            downWing[2].Y = _startPosY + 8;
            g.FillPolygon(mainBrush, downWing);

            PointF[] downSmallWing = new PointF[3];
            downSmallWing[0].X = _startPosX + 88;
            downSmallWing[0].Y = _startPosY + 8;
            downSmallWing[1].X = _startPosX + 104;
            downSmallWing[1].Y = _startPosY + 36;
            downSmallWing[2].X = _startPosX + 104;
            downSmallWing[2].Y = _startPosY + 8;
            g.FillPolygon(mainBrush, downSmallWing);

            PointF[] upSmallWing = new PointF[3];
            upSmallWing[0].X = _startPosX + 88;
            upSmallWing[0].Y = _startPosY - 8;
            upSmallWing[1].X = _startPosX + 104;
            upSmallWing[1].Y = _startPosY - 36;
            upSmallWing[2].X = _startPosX + 104;
            upSmallWing[2].Y = _startPosY - 8;
            g.FillPolygon(mainBrush, upSmallWing);
            g.FillEllipse(new SolidBrush(Color.Blue), _startPosX + 28, _startPosY - 6, 16, 12);

            if (isEngines)
            {
                g.FillRectangle(dopBrush, _startPosX + 104, _startPosY - 8, 9, 7);
                g.FillRectangle(dopBrush, _startPosX + 104, _startPosY + 1, 9, 7);
            }


        }



    }

}
