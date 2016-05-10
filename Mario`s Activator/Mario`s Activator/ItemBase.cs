using EloBuddy;
using EloBuddy.SDK;
using Mario_s_Lib;
using static Mario_s_Activator.Items;

namespace Mario_s_Activator
{
    public abstract class ItemBase
    {
        public Item thisItem;
        public AIHeroClient thisTarget;
        private bool Initialized;

        public abstract void InitializeItem();
        public abstract void Execute();

        public void OnTick()
        {
            if (!OwnedItems.Contains(thisItem)) return;

            if (!Initialized)
            {
                InitializeItem();
                Initialized = true;
            }

            thisTarget = Misc.Extensions.GetBestItemTarget(thisItem);
            var menuValue = MyMenu.OffensiveMenu.GetCheckBoxValue("check" + (int) thisItem.Id);

            if (!thisItem.IsReady() || !menuValue || thisTarget == null) return;

            Execute();
        }
    }
}
