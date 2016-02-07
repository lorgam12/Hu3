using System.Linq;
using EloBuddy;
using EloBuddy.SDK.Enumerations;
using SpellLibrary.DataBases;

namespace SpellLibrary
{
    public static class Returns
    {
        public static int GetRange(this AIHeroClient player, SpellSlot slot)
        {
            var get = Spells.SpellsData.FirstOrDefault(s => s.Hero == player.Hero && s.Slot == slot);
            return get?.Range ?? 0;
        }

        public static int GetDelay(this AIHeroClient player, SpellSlot slot)
        {
            var get = Spells.SpellsData.FirstOrDefault(s => s.Hero == player.Hero && s.Slot == slot);
            return get?.Delay ?? 0;
        }

        public static int GetWidth(this AIHeroClient player, SpellSlot slot)
        {
            var get = Spells.SpellsData.FirstOrDefault(s => s.Hero == player.Hero && s.Slot == slot);
            return get?.Width ?? 0;
        }

        public static int GetSpeed(this AIHeroClient player, SpellSlot slot)
        {
            var get = Spells.SpellsData.FirstOrDefault(s => s.Hero == player.Hero && s.Slot == slot);
            return get?.Speed ?? 0;
        }
        //Damage
    }
}
