using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace WindowsFormsPlaneUsl
{
    public class Warplane : Plane, IComparable<Warplane>, IEnumerable<object>, IEnumerator<object>
    {
        private List<object> properties = new List<object>();

        protected readonly int warplaneWidth = 113;

        protected readonly int warplaneHeight = 128;

        protected readonly char separator = ';';        protected int _currentIndex = -1;        public object Current => properties.ElementAt(_currentIndex);        object IEnumerator.Current => properties.ElementAt(_currentIndex);
        public Warplane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            properties.Add(MaxSpeed);
            properties.Add(Weight);
            properties.Add(MainColor);
            properties.Add(warplaneWidth);
            properties.Add(warplaneHeight);
        }

        protected Warplane(int maxSpeed, float weight, Color mainColor, int warplaneWidth, int
       warplaneHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.warplaneWidth = warplaneWidth;
            this.warplaneHeight = warplaneHeight;
            properties.Add(MaxSpeed);
            properties.Add(Weight);
            properties.Add(MainColor);
            properties.Add(warplaneWidth);
            properties.Add(warplaneHeight);
        }

        public Warplane(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                properties.Add(MaxSpeed);
                properties.Add(Weight);
                properties.Add(MainColor);
                properties.Add(warplaneWidth);
                properties.Add(warplaneHeight);
            }
        }

        public override void MoveTransport(Direction direction)
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
        }        public override void DrawTransport(Graphics g)
        {
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

        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
        public bool Equals(Warplane other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Warplane warplaneObj))
            {
                return false;
            }
            else
            {
                return Equals(warplaneObj);
            }
        }

        public int CompareTo(Warplane other)
        {
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                return MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < 3;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
