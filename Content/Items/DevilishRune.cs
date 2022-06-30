using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items
{
    public class DevilishRune : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Devilish Rune");
            Tooltip.SetDefault("Used to craft Devilish items");
        }

        public override void SetDefaults()
        {
            Item.width = 37;
            Item.height = 37;
            Item.maxStack = 9999;
            Item.value = 1000;
            Item.rare = 4;
        } 
    }
}
