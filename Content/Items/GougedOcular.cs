using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items;
public class GougedOcular : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Gouged Ocular");
        // Tooltip.SetDefault("'It writhes in the palm of your hand...'");
    }
    public override void SetDefaults()
    {
        Item.width = 24;
        Item.height = 24;
        Item.maxStack = 9999;
        Item.rare = ItemRarityID.LightRed;
        //Item.value = Item.sellPrice(silver: 10);
    }
}