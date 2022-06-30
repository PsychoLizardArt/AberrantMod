using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Weapons.Melee
{
    public class TricksterTomahawk : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bishop");
            Tooltip.SetDefault("A returning tomahawk that passes through blocks");
        }

        public override void SetDefaults()
        {
            Item.width = 66;
            Item.height = 58;
            Item.useStyle = 1;
            Item.useAnimation = 20;
            Item.useTime = 20;
            Item.shootSpeed = 22f;
            Item.knockBack = 2.5f;
            Item.damage = 34;
            Item.rare = 3;

            Item.autoReuse = true;


            Item.DamageType = DamageClass.Melee;
            Item.noMelee = true;
            Item.noUseGraphic = true;
            Item.channel = true;

            Item.UseSound = SoundID.Item7;
            Item.shoot = Mod.Find<ModProjectile>("TricksterTomahawkProj").Type;

            Item.value = Item.buyPrice(0, 12, 0, 0);


            
        }

    }
}
