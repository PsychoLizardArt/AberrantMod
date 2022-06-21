using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aberrant.Content.Items.Weapons.Melee
{
    public class TricksterTomahawk : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bishop");

        }

        public override void SetDefaults()
        {
            item.width = 66;
            item.height = 58;
            item.useStyle = 1;
            item.useAnimation = 20;
            item.useTime = 20;
            item.shootSpeed = 22f;
            item.knockBack = 2.5f;
            item.damage = 34;
            item.rare = 3;

            item.autoReuse = true;
           

            item.melee = true;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.channel = true;

            item.UseSound = SoundID.Item7;
            item.shoot = mod.ProjectileType("TricksterTomahawkProj");

            item.value = Item.buyPrice(0, 12, 0, 0);


            
        }

    }
}