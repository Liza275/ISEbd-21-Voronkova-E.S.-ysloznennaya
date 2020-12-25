using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlaneUsl
{
    class AirportOverflowException : Exception
    {
        public AirportOverflowException() : base("В аэропорту нет свободных мест")
        {
        }
    }
}
