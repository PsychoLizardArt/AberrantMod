using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AberrantMod.Content.Items.Accessories;
public class BloodContract : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Blood Contract");
        // Tooltip.SetDefault("Increases your max number of minions by 1" + "\nSlowly regenerates life");
    }
    public override void SetDefaults()
    {
        Item.width = 34;
        Item.height = 36;
        Item.accessory = true;
        Item.value = Item.buyPrice(0, 5, 0, 0);
        Item.rare = ItemRarityID.Blue;
    }
    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.lifeRegen++;
        player.maxMinions++;
    }
}