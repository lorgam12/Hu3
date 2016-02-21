using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;

namespace Tutorial_EB
{
    class Program
    {
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Loading_OnLoadingComplete;
        }

        private static Spell.Active Q;
        private static Spell.Skillshot W;
        private static Spell.Targeted E;
        private static Spell.Active R;

        private static void Loading_OnLoadingComplete(EventArgs args)
        {
            Q = new Spell.Active(SpellSlot.Q, (uint)Player.Instance.GetAutoAttackRange());
            W = new Spell.Skillshot(SpellSlot.W, 600, SkillShotType.Cone, 250, 2400, 65);
            E = new Spell.Targeted(SpellSlot.E, 700);
            R = new Spell.Active(SpellSlot.R, 500);

            Game.OnTick += Game_OnTick;
        }

        private static void Game_OnTick(EventArgs args)
        {
            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo))
            {
                var target = TargetSelector.GetTarget(E.Range, DamageType.Magical);
                if(target == null) return;
                if (E.IsReady() && target.IsInRange(Player.Instance, E.Range))
                {
                    E.Cast(target);
                }

                if (W.IsReady() && target.IsInRange(Player.Instance, W.Range))
                {
                    W.Cast(Player.Instance);
                }
            }

            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Harass))
            {
                var target = TargetSelector.GetTarget(E.Range, DamageType.Magical);
                if (target == null) return;
                if (E.IsReady() && target.IsInRange(Player.Instance, E.Range))
                {
                    E.Cast(target);
                }
            }

            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.LaneClear))
            {
                var minion =
                    EntityManager.MinionsAndMonsters.GetLaneMinions()
                        .FirstOrDefault(m => m.IsInRange(Player.Instance, E.Range) && m.IsEnemy);
                if(minion == null)return;

                if (E.IsReady())
                {
                    E.Cast(minion);
                }
            }

            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.JungleClear))
            {
                var jungleMinion =
                    EntityManager.MinionsAndMonsters.GetJungleMonsters()
                        .FirstOrDefault(m => m.IsInRange(Player.Instance, E.Range));
                if(jungleMinion == null)return;
                if (E.IsReady())
                {
                    E.Cast(jungleMinion);
                }
            }

            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.LastHit))
            {
                var lastHitMinion =
                    EntityManager.MinionsAndMonsters.GetLaneMinions()
                        .FirstOrDefault(m => m.IsEnemy && m.IsInRange(Player.Instance, E.Range) && m.Health < Player.Instance.GetSpellDamage(m, SpellSlot.E));

                if(lastHitMinion == null)return;

                if (E.IsReady())
                {
                    E.Cast(lastHitMinion);
                }
            }

            if (Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Flee))
            {

            }
        }
    }
}
