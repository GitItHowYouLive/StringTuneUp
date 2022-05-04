using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTuneUp
{
    static class MusicFactory
    {
        public static IStringed GetInstrument()
        {
            Console.WriteLine("How many strings would you like on your instrument?" +
                "\nPlease choose anywhere from 4-8 strings.");

            if(!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("It's not that tough to pick a number. Try again.");
                return GetInstrument();
            }

            switch (choice)
            {
                case 4:
                    Console.WriteLine("Sweet! Lay down some thumping grooves!");
                    return new Bass();
                case 5:
                    Console.WriteLine("NICE! Versatility, funk, and power, all in one package!");
                    return new Bass() { Strings = 5, Tuning = "BEADG", NeckLength = 35};
                case 6:
                    Console.WriteLine("A standard choice for a reason. Welcome to the world of guitar!");
                    return new Guitar();
                case 7:
                    Console.WriteLine("Now you don't see one of these every day. Are you a Tosin Abasi fan?");
                    return new Guitar() { NeckLength = 27, Strings = 7, Tuning = "BEADGBE" };
                case 8:
                    Console.WriteLine("You must love a challenge! Here's an eight-stringed guitar for you, Ewie Jr!");
                    return new Guitar() {Strings = 8, Tuning = "FBEADGBE", NeckLength = 28.75 };
                default:
                    Console.WriteLine("Wow, you're a rebel. Unless you want a kazoo, try again and follow instructions.");
                    return GetInstrument();
            }
        }
    }
}
