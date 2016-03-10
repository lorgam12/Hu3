using System;
using EloBuddy;
using EloBuddy.SDK.Events;

namespace BottingMode
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Loaded!");
            Hacks.DisableTextures = true;
            Console.WriteLine(Hacks.DisableTextures);
        }
    }
}
