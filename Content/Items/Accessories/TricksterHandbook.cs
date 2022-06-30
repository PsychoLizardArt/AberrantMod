using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Accessories
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
            Item.width = 32;
            Item.height = 30;
            Item.accessory = true;
            Item.value = Item.buyPrice(0, 10, 0, 0);
            Item.rare = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.moveSpeed += 0.1f;
            player.runAcceleration += 0.1f;
            player.noKnockback = true;
            player.GetDamage(DamageClass.Melee) += 0.05f;
        }
    }
}
