using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlaneUsl
{
    class AirportCollection
    {
        readonly Dictionary<string, Airport<Plane, IDrawingElements>> parkingStages;

        public List<string> Keys => parkingStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;

        public AirportCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Airport<Plane, IDrawingElements>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddAirport(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Airport<Plane, IDrawingElements>(pictureWidth, pictureHeight));
        }

        public void DelAirport(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Airport<Plane, IDrawingElements> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }

        }

        public IFlyingTransport this[string key, int index]
        {
            get
            {
                if (parkingStages.ContainsKey(key))
                {
                    return parkingStages[key][index];
                }
                return null;
            }
        }
    }
}
