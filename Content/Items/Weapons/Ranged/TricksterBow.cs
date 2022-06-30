using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Weapons.Ranged
{
    public class TricksterBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("King");
            Tooltip.SetDefault("Magically transforms one arrow into three");
            
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 70;
            Item.useStyle = 5;
            
            Item.shootSpeed = 25f;
            Item.knockBack = 2f;
            Item.rare = 3;
            Item.useTurn = false;

            Item.autoReuse = true;
            Item.noMelee = true;
            Item.UseSound = SoundID.Item101;
            Item.useAnimation = 24;
            Item.useTime = 8;
            Item.reuseDelay = 14;
            Item.consumeAmmoOnLastShotOnly = true;
           

            Item.damage = 19;

            Item.shoot = 10;
            Item.DamageType = DamageClass.Ranged;
            Item.useAmmo = AmmoID.Arrow;

            Item.value = Item.buyPrice(0, 12, 0, 0);
        }
    }
}
