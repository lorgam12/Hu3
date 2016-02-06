﻿using EloBuddy;
using EloBuddy.SDK;

using Settings = KA_Riven.Config.Modes.Combo;

namespace KA_Riven.Modes
{
    public sealed class Combo : ModeBase
    {
        public override bool ShouldBeExecuted()
        {
            return Orbwalker.ActiveModesFlags.HasFlag(Orbwalker.ActiveModes.Combo);
        }

        public override void Execute()
        {
            var target = TargetSelector.GetTarget(Q.Range, DamageType.Magical);
            if (target == null || target.IsZombie || target.HasUndyingBuff()) return;

            if (Q.IsReady() && target.IsValidTarget(Q.Range) && Settings.UseQ && EventsManager.CanQ)
            {
                Q.Cast(target);
            }
            /*
            if (E.IsReady() && target.IsValidTarget(E.Range) && Settings.UseE)
            {
                E.Cast(target);
            }

            if (W.IsReady() && target.IsValidTarget(W.Range) && Settings.UseW)
            {
                W.Cast();
            }

            if (R.IsReady() && Settings.UseR)
            {
                var targetR = TargetSelector.GetTarget(Q.Range + R.Range + 50, DamageType.Magical);

                if (target.IsValidTarget(R.Range + Q.Range - 50) && targetR.CountEnemiesInRange(800) <= 2 &&
                    Player.Instance.HealthPercent > targetR.HealthPercent && targetR.HealthPercent <= 50 ||
                    targetR.Health < SpellDamage.GetTotalDamage(targetR))
                {
                    R.Cast(Player.Instance.Position.Extend(target.Position, R.Range + 250).To3D());
                }
            }
            */
        }
    }
}
