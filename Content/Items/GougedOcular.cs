using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items
{
    public class GougedOcular : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gouged Ocular");
            Tooltip.SetDefault("It writhes in your palm");
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.maxStack = 9999;
            Item.value = 10000;
            Item.rare = 4;
        }

    }
}
