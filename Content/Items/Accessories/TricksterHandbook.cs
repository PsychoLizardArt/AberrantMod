using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aberrant.Content.Items.Accessories
{
    public class TricksterHandbook : ModItem //prehardmode
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Trickster's Handbook");
            Tooltip.SetDefault("10% increased movement speed" +
                                "\n5% increased melee damage" +
                                "\nGrants immunity to knockback");                     
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 30;
            item.accessory = true;
            item.value = Item.buyPrice(0, 10, 0, 0);
            item.rare = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 0.1f;
            player.runAcceleration += 0.1f;
            player.noKnockback = true;
            player.meleeDamage += 0.05f;
        }
    }
}