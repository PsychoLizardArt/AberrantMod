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
            item.width = 37;
            item.height = 37;
            item.maxStack = 9999;
            item.value = 1000;
            item.rare = 4;
        } 
    }
}
