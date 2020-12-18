using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly char separator = ':';

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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine("AirportCollection");
                foreach (var level in parkingStages)
                {
                    sw.WriteLine($"Airport{separator}{level.Key}");
                    IFlyingTransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (plane != null)
                        {
                            if (plane.GetType().Name == "Warplane")
                            {
                                sw.Write($"Warplane{separator}");
                            }
                            if (plane.GetType().Name == "Fighter")
                            {
                                sw.Write($"Fighter{separator}");
                            }
                            sw.WriteLine(plane);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                string line = sr.ReadLine();
                if (line.Contains("AirportCollection"))
                {
                    parkingStages.Clear();
                }
                else
                {
                    return false;
                }
                Plane plane = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("Airport"))
                    {
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Airport<Plane, IDrawingElements>(pictureWidth,
                        pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(separator)[0] == "Warplane")
                    {
                        plane = new Warplane(line.Split(separator)[1]);
                    }
                    else if (line.Split(separator)[0] == "Fighter")
                    {
                        plane = new Fighter(line.Split(separator)[1]);
                    }
                    var result = parkingStages[key] + plane;
                    if (!result)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool SaveAirport(string filename, string key)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if (!parkingStages.ContainsKey(key))
            {
                return false;
            }
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.Default))
            {
                sw.WriteLine($"Airplane{separator}{key}");
                Plane plane = null;
                for (int i = 0; (plane = parkingStages[key].GetNext(i)) != null; i++)
                {
                    if (plane != null)
                    {
                        if (plane.GetType().Name == "Warplane")
                        {
                            sw.Write($"Warplane{separator}");
                        }
                        if (plane.GetType().Name == "Fighter")
                        {
                            sw.Write($"Fighter{separator}");
                        }
                        sw.WriteLine(plane);
                    }
                }
            }
            return true;
        }

        public bool LoadAirport(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename, Encoding.Default))
            {
                string line = sr.ReadLine();
                if (!line.Contains("Airplane:"))
                {
                    return false;
                }
                string key = line.Split(separator)[1];
                if (parkingStages.ContainsKey(key))
                {
                    parkingStages[key].Clear();
                }
                else
                {
                    parkingStages.Add(key, new Airport<Plane, IDrawingElements>(pictureWidth, pictureHeight));
                }
                Warplane plane = null;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains(separator))
                    {
                        if (line.Contains("Warplane"))
                        {
                            plane = new Warplane(line.Split(separator)[1]);
                        }
                        else if (line.Contains("Fighter"))
                        {
                            plane = new Fighter(line.Split(separator)[1]);
                        }
                        if (!(parkingStages[key] + plane))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }
}
