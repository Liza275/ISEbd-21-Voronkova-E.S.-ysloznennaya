using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlaneUsl
{
    class PlaneComparer : IComparer<Plane>
    {
        public int Compare(Plane x, Plane y)
        {
            if (x is Fighter && y is Fighter)
            {
                return ComparerFighter((Fighter)x, (Fighter)y);
            }
            if (x is Fighter && y is Warplane)
            {
                return 1;
            }
            if (x is Warplane && y is Fighter)
            {
                return -1;
            }
            if (x is Warplane && y is Warplane)
            {
                return ComparerPlane((Warplane)x, (Warplane)y);
            }
            return 0;
        }
        private int ComparerPlane(Warplane x, Warplane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerFighter(Fighter x, Fighter y)
        {
            var res = ComparerPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.isEngines != y.isEngines)
            {
                return x.isEngines.CompareTo(y.isEngines);
            }
            if (x.isRockets != y.isRockets)
            {
                return x.isRockets.CompareTo(y.isRockets);
            }
            return 0;
        }
    }
}