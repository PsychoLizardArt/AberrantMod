using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Accessories
{
    public class BloodContract : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Contract");
            Tooltip.SetDefault("Increases your max number of minions by 1" +
                                "\nSlowly regenerates life");
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 36;
            Item.accessory = true;
            Item.value = Item.buyPrice(0, 5, 0, 0);
            Item.rare = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lifeRegen += 2;
            player.maxMinions += 1;
        }
    }
}