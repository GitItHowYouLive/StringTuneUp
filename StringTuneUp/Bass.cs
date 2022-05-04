using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTuneUp
{
    internal class Bass : IStringed
    {
        public int Strings { get; set; } = 4;
        public double NeckLength { get; set; } = 34;
        public string Material { get; set; } = "basswood";
        public string Tuning { get; set; } = "EADG";
        public void Play()
        {
            Console.WriteLine("Beautiful, resonant tones explode from your amplifier...");
        }
    }
}
