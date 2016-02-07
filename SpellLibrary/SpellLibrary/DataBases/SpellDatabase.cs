using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;

namespace SpellLibrary.DataBases
{
    public class Spell
    {
        public Spell(Champion hero, SpellSlot slot, int range, int delay, int speed, int width, int allowedcollision = 0)
        {
            Slot = slot;
            Hero = hero;
            Range = range;
            Delay = delay;
            Speed = speed;
            Width = width;
            AllowedCollision = allowedcollision;
        }

        public SpellSlot Slot;
        public Champion Hero;
        public int Range;
        public int Delay;
        public int Speed;
        public int Width;
        public int AllowedCollision;
    }

    public class Spells
    {
        public static List<Spell> SpellsData = new List<Spell>
        {
            //Aatrox
            new Spell(Champion.Aatrox, SpellSlot.Q, 650, 250, 2000, 285),
            new Spell(Champion.Aatrox, SpellSlot.W, 150, 0, int.MaxValue, 0),
            new Spell(Champion.Aatrox, SpellSlot.E, 1075, 250, 1200, 60, int.MaxValue),
            new Spell(Champion.Aatrox, SpellSlot.R, 550, 0, int.MaxValue, 0),
            //Ahri
            new Spell(Champion.Ahri, SpellSlot.Q, 925, 250, 1750, 60),
            new Spell(Champion.Ahri, SpellSlot.W, 700, 0, int.MaxValue, 0),
            new Spell(Champion.Ahri, SpellSlot.E, 1000, 250, 1530, 60),
            new Spell(Champion.Ahri, SpellSlot.R, 500, 250, 1575, 0),
            //Akali
            new Spell(Champion.Akali, SpellSlot.Q, 600, 250, int.MaxValue, 0),
            new Spell(Champion.Akali, SpellSlot.W, 700, 250, int.MaxValue, 400),
            new Spell(Champion.Akali, SpellSlot.E, 325, 250, int.MaxValue, 0),
            new Spell(Champion.Akali, SpellSlot.R, 700, 250, int.MaxValue, 0),
            //Alistar
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Amumu, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Amumu, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Amumu, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Amumu, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Anivia
            new Spell(Champion.Anivia, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Anivia, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Anivia, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Anivia, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Annie
            new Spell(Champion.Annie, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Annie, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Annie, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Annie, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Ashe
            new Spell(Champion.Ashe, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Ashe, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Ashe, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Ashe, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Azir
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Bard
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Blitzcrank
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Brand
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Braum
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Caitlyn
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Cassiopeia
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),
            //Amumu
            new Spell(Champion.Alistar, SpellSlot.Q, 365, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.W, 650, 250, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.E, 575, 0, int.MaxValue, 0),
            new Spell(Champion.Alistar, SpellSlot.R, 0, 0, int.MaxValue, 0),



        };
    }
}
