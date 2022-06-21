using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Aberrant.Content.Items
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
            item.width = 24;
            item.height = 24;
            item.maxStack = 9999;
            item.value = 10000;
            item.rare = 4;
        }

    }
}