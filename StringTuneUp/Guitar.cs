using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTuneUp
{
    internal class Guitar : IStringed
    {
        public int Strings { get; set; } = 6;
        public double NeckLength { get; set; } = 25.5;
        public string Material { get; set; } = "mahogany";
        public string Tuning { get; set; } = "EADGCE";
        public void Play()
        {
            Console.WriteLine("Your fingers strum elegant chords across a delicate fretboard...");
        }
    }
}
