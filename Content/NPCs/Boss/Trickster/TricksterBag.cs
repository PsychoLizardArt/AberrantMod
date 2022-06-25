using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AberrantMod.Content.NPCs.Boss.Trickster
{
    public class TricksterBag : ModItem
    {
        public override int BossBagNPC => mod.NPCType("Trickster");

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("<right> to open");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 9999;
            item.consumable = true;
            item.rare = 9;
            item.expert = true;
        }

        public override void OpenBossBag(Player player)
        {
            player.QuickSpawnItem(ItemID.GoldCoin, 50);
            player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 10));
            player.QuickSpawnItem(ItemID.ManaPotion, Main.rand.Next(3, 7));
            if(Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("TricksterHandbook"));
            }
            
        }
    }
}
