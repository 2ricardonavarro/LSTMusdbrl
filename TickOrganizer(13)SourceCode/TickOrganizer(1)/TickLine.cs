using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickOrganizer_1_
{
    class TickLine
    {
        public double Volume { get; set; }
        public double LastPrice { get; set; }
        public Dictionary<string, double> dictCorretoras = new Dictionary<string, double>();


    }
}
