﻿using System;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using KA_Activator.Maps.SummonersRift.DMGHandler;

using Misc = KA_Activator.Maps.SummonersRift.Config.Types.Settings;
using Settings = KA_Activator.Maps.SummonersRift.Config.Types.DeffensiveItems;

namespace KA_Activator.Maps.SummonersRift.Items
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Defensive : Ids
    {
        public static void Execute()
        {
            if (Player.Instance.IsInShopRange() || Player.Instance.CountAlliesInRange(Misc.RangeEnemy) < Misc.EnemyCount ||
                Activator.lastUsed >= Environment.TickCount) return;

            #region Self

            if (Zhonyas.IsReady() && Zhonyas.IsOwned() && Player.Instance.InDanger(Settings.ZhonyasMyHp) &&
                Settings.Zhonyas)
            {
                Zhonyas.Cast();
                Activator.lastUsed = Environment.TickCount + 1500;
            }

            if (Seraph.IsReady() && Seraph.IsOwned() && Player.Instance.InDanger(Settings.MYHPSeraph) &&
                Settings.UseSeraph)
            {
                Seraph.Cast();
                Activator.lastUsed = Environment.TickCount + 1500;
            }

            if (Talisman.IsReady() && Player.Instance.CountAlliesInRange(450) >= 2 && Talisman.IsOwned() &&
                Player.Instance.InDanger(30))
            {
                Talisman.Cast();
                Activator.lastUsed = Environment.TickCount + 1500;
            }

            if (Randuin.IsReady() && Player.Instance.CountEnemiesInRange(Randuin.Range) >= 2 && Randuin.IsOwned() &&
                Player.Instance.InDanger(30))
            {
                Randuin.Cast();
                Activator.lastUsed = Environment.TickCount + 500;
            }
            //Allies
            if (FaceOfTheMountain.IsReady() && FaceOfTheMountain.IsOwned())
            {
                var allyFace = EntityManager.Heroes.Allies.FirstOrDefault(a => a.InDanger(Settings.AllyHPFaceOfTheMountain));
                if(allyFace != null)
                {
                    FaceOfTheMountain.Cast(allyFace);
                    Activator.lastUsed = Environment.TickCount + 500;
                }
            }

            if (Mikael.IsReady() && Player.Instance.HasCCs() && Mikael.IsOwned())
            {
                var allyMikael = EntityManager.Heroes.Allies.FirstOrDefault(a => a.InDanger(Settings.AllyHPMikaelHeal));
                if (allyMikael != null)
                {
                    Mikael.Cast(allyMikael);
                    Activator.lastUsed = Environment.TickCount + 500;
                }
            }

            if (Solari.IsReady() && Solari.IsOwned())
            {
                var allySolari = EntityManager.Heroes.Allies.FirstOrDefault(a => a.InDanger(Settings.AllyHealthSolari));
                if (allySolari != null)
                {
                    Solari.Cast();
                    Activator.lastUsed = Environment.TickCount + 1500;
                }
            }

            if (Ohm.IsReady() && Ohm.IsOwned())
            {
                var turret = EntityManager.Turrets.Enemies.FirstOrDefault(t => t.IsAttackingPlayer);
                var allyFace = EntityManager.Heroes.Allies.FirstOrDefault(a => a.InDanger(Settings.OhmHealth));
                if (allyFace != null && turret != null)
                {
                    Ohm.Cast(turret);
                    Activator.lastUsed = Environment.TickCount + 500;
                }
            }

            //CC

            if (DerbishBlade.IsReady() && DerbishBlade.IsOwned() && Settings.DerbishBlade && Player.Instance.HasCCs())
            {
                Core.DelayAction(() => DerbishBlade.Cast(), Settings.CleanseDelay);
                Activator.lastUsed = Environment.TickCount + 1500;
            }

            if (Mercurial.IsReady() && Mercurial.IsOwned() && Settings.Mercurial && Player.Instance.HasCCs())
            {
                Core.DelayAction(() => Mercurial.Cast(), Settings.CleanseDelay);
                Activator.lastUsed = Environment.TickCount + 1500;
            }

            if (QuickSilver.IsReady() && QuickSilver.IsOwned() && Settings.QuickSilver && Player.Instance.HasCCs())
            {
                Core.DelayAction(() => QuickSilver.Cast(), Settings.CleanseDelay);
                Activator.lastUsed = Environment.TickCount + 1500;
            }

            var ally = EntityManager.Heroes.Allies.FirstOrDefault(a => a.IsValidTarget(Mikael.Range));
            if (ally == null) return;
            if (!ally.HasCCs()) return;

            if (Mikael.IsReady() && Mikael.IsOwned() && Settings.MikaelCleanse)
            {
                Core.DelayAction(() => Mikael.Cast(ally), Settings.CleanseDelay);
                Activator.lastUsed = Environment.TickCount + 1500;
            }

            #endregion Self
        }
    }
}


