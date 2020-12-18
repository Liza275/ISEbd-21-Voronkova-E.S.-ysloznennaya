using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlaneUsl
{
    public class Airport<T, R> where T : class, IFlyingTransport where R : IDrawingElements
    {
        private readonly List<T> _places;
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int _maxCount;
        private readonly int _placeSizeWidth = 215;
        private readonly int _placeSizeHeight = 137;
        private readonly int placesInRow;


        public Airport(int picWidht, int picHeight)
        {
            int widht = picWidht / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            placesInRow = height;
            _maxCount = widht * height;
            _places = new List<T>();
            pictureWidth = picWidht;
            pictureHeight = picHeight;
        }

        public T this[int ind]
        {
            get
            {
                if (ind >= 0 && ind < _places.Count)
                {
                    return _places.ElementAt(ind);
                }
                return null;
            }
        }

        public static bool operator +(Airport<T, R> p, T plane)
        {
            if (p._places.Count >= p._maxCount)
            {
                return false;
            }
            p._places.Add(plane);
            return true;
        }

        public static T operator -(Airport<T, R> p, int index)
        {
            if (index < -1 || index > p._places.Count)
            {
                return null;
            }
            T plane = p._places[index];
            p._places.RemoveAt(index);
            return plane;
        }

        public static bool operator >(Airport<T, R> airport1, Airport<T, R> airport2)
        {
            return airport1._places.Count > airport2._places.Count;
        }

        public static bool operator <(Airport<T, R> airport1, Airport<T, R> airport2)
        {
            return airport1._places.Count < airport2._places.Count;
        }

        //отрисовка парковки
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < _places.Count; i++)
            {
                int x = (i / placesInRow) * _placeSizeWidth;
                int y = (i - placesInRow * (i / placesInRow)) * _placeSizeHeight + (_placeSizeHeight - 5) / 2;
                _places[i]?.SetPosition(x + 5, y + 5, pictureWidth, pictureHeight);
                _places[i]?.DrawTransport(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                   _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
               (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }

        public T GetNext(int index)
        {
            if (index < 0 || index >= _places.Count)
            {
                return null;
            }
            return _places[index];
        }
        public void Clear()
        {
            _places.Clear();
        }
    }
}
