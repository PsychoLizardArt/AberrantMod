using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aberrant.Content.Items.Accessories
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
            item.width = 34;
            item.height = 36;
            item.accessory = true;
            item.value = Item.buyPrice(0, 5, 0, 0);
            item.rare = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lifeRegen += 2;
            player.maxMinions += 1;
        }
    }
}