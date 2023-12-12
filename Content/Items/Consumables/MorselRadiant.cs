using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Consumables;
public class MorselRadiant : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 18;
        Item.height = 18;
        Item.maxStack = 9999;
        Item.rare = ItemRarityID.Green;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.useStyle = 2;
        Item.UseSound = SoundID.Item2;
        Item.consumable = true;
        Item.value = Item.buyPrice(0, 5, 0, 0);
    }
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Radiant Morsel");
        // Tooltip.SetDefault("Sets time to day upon consumption\n'Where did Toko get this?'");
    }
    public override bool CanUseItem(Player player)
    {
        if (!Main.dayTime)
            return true;
        return false;
    }
    public override bool? UseItem(Player player)
    {
        Main.dayTime = true;
        Main.time = 0.0;
        Main.NewText("The world is blessed with sunshine...", 255, 240, 20);
        return true;
    }
}