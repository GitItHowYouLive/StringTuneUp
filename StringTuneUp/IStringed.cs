using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTuneUp
{
    internal interface IStringed
    {
        public int Strings { get; set; }
        public double NeckLength { get; set; }
        public string Material { get; set; }
        public string Tuning { get; set; }
        public void Play();
    }
}
