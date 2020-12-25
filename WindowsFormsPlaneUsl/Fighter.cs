using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlaneUsl
{
    public class Fighter : Warplane, IComparable<Fighter>, IEnumerable<object>, IEnumerator<object>
    {

        private List<object> properties = new List<object>();

        public IDrawingElements db { set; get; }

        public Color DopColor { private set; get; }
        public bool isEngines { private set; get; }

        public bool isRockets { private set; get; }

        public object Current => properties.ElementAt(_currentIndex);

        object IEnumerator.Current => properties.ElementAt(_currentIndex);


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
            properties.Add(MaxSpeed);
            properties.Add(Weight);
            properties.Add(MainColor);
            properties.Add(warplaneWidth);
            properties.Add(warplaneHeight);
            properties.Add(bombsForm);
            properties.Add(bombsNum);
            properties.Add(dopColor);
            properties.Add(isEngines);
            properties.Add(IsRockets);
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
                properties.Add(MaxSpeed);
                properties.Add(Weight);
                properties.Add(MainColor);
                properties.Add(warplaneWidth);
                properties.Add(warplaneHeight);
                properties.Add(strs[7]);
                properties.Add(Convert.ToInt32(strs[6]));
                properties.Add(DopColor);
                properties.Add(isEngines);
                properties.Add(isRockets);
            }
        }


        public override void DrawTransport(Graphics g)
        {
            base.DrawTransport(g);
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
        public bool Equals(Fighter other)
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
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (isEngines != other.isEngines)
            {
                return false;
            }
            if (isRockets != other.isRockets)
            {
                return false;
            }
            if (db.GetType() != other.db.GetType())
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
            if (!(obj is Fighter warplaneObj))
            {
                return false;
            }
            else
            {
                return Equals(warplaneObj);
            }
        }

        public int CompareTo(Fighter other)
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
            if (DopColor != other.DopColor)
            {
                return DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (isEngines != other.isEngines)
            {
                return isEngines.CompareTo(other.isEngines);
            }
            if (isRockets != other.isRockets)
            {
                return isRockets.CompareTo(other.isRockets);
            }
            return 0;
        }

        public new bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < 8;
        }

        public void Dispose()
        {

        }

        public new void Reset()
        {
            _currentIndex = -1;
        }

        public new IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}
