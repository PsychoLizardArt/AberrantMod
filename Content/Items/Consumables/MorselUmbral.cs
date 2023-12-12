using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Consumables;
public class MorselUmbral : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 18;
        Item.height = 18;
        Item.maxStack = 9999;
        Item.rare = ItemRarityID.Green;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.useStyle = ItemUseStyleID.EatFood;
        Item.UseSound = SoundID.Item2;
        Item.consumable = true;
        Item.value = Item.buyPrice(0, 5, 0, 0);
    }
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Umbral Morsel");
        // Tooltip.SetDefault("Sets time to night upon consumption\n'Where did Toko get this?'");
    }
    public override bool CanUseItem(Player player)
    {
        if (Main.dayTime)
            return true;
        return false;
    }
    public override bool? UseItem(Player player)
    {
        Main.dayTime = false;
        Main.time = 0.0;
        Main.NewText("The world is soaked in darkness...", 255, 240, 20);
        return true;
    }
}
