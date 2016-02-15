using System;
using System.Collections.Generic;
using System.Linq;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
using SharpDX;
using Color = System.Drawing.Color;

namespace PathDebug
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Loading.OnLoadingComplete += Loading_OnLoadingComplete;
        }

        private static void Loading_OnLoadingComplete(EventArgs args)
        {
            Obj_AI_Base.OnNewPath += Obj_AI_Base_OnNewPath;
            Drawing.OnDraw += Drawing_OnDraw;
        }

        private static void Drawing_OnDraw(EventArgs args)
        {
            foreach (var p in Paths)
            {
                Circle.Draw(SharpDX.Color.Red, 10f, 1f, p);
            }
            var first = Paths.First();
            var last = Paths.Last();
            if(first !=null && last != null)
            {
                Circle.Draw(SharpDX.Color.Blue, 10f, 2f, first);
                Circle.Draw(SharpDX.Color.Purple, 10f, 2f, last);
            }
            Line.DrawLine(Color.DarkRed, Paths);

            foreach (var p in Path)
            {
                Circle.Draw(SharpDX.Color.PeachPuff, 40f, 1f, p);
            }
        }

        private static Vector3[] Paths;
        private static List<Vector3>Path = new List<Vector3>();

        private static void Obj_AI_Base_OnNewPath(Obj_AI_Base sender, GameObjectNewPathEventArgs args)
        {
            var hero = sender as AIHeroClient;
            if(hero ==  null)return;
            Chat.Print("Length " +args.Path.Length);
            foreach (var p in args.Path)
            {
                Path.Add(p);
                Core.DelayAction(() => Path.Remove(p), 1000);
            }
            Chat.Print("Count " + Path.Count);
            Paths = args.Path;
        }
    }
}
