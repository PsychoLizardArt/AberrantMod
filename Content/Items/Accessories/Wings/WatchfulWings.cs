using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Accessories.Wings;
public class WatchfulWings : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Watchful Wings");
        //ArmorIDs.Wing.Sets.Stats[Item.wingSlot] = new WingStats(30, 1f, 1f);
    }
    public override void SetDefaults()
    {
        Item.accessory = true;
        Item.width = 28;
        Item.height = 26;
        Item.value = ItemRarityID.Blue;
        Item.rare = Item.buyPrice(gold: 1);
    }
    public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
    {
        ascentWhenFalling = 1f;
        ascentWhenRising = 0.1f;
        maxCanAscendMultiplier = 1f;
        maxAscentMultiplier = 1f;
        constantAscend = 0.1f;
    }
}