using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aberrant.Content.Items.Weapons.Ranged
{
    public class TricksterBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("King");
            
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 70;
            item.useStyle = 5;
            
            item.shootSpeed = 25f;
            item.knockBack = 2f;
            item.rare = 3;
            item.useTurn = false;

            item.autoReuse = true;
            item.noMelee = true;
            item.UseSound = SoundID.Item101;
            item.useAnimation = 24;
            item.useTime = 8;
            item.reuseDelay = 14;
           

            item.damage = 19;

            item.shoot = 10;
            item.ranged = true;
            item.useAmmo = AmmoID.Arrow;

            item.value = Item.buyPrice(0, 12, 0, 0);
        }

        public override bool ConsumeAmmo(Player player)
        {
            // Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (useAnimation - 1, then - useTime until less than 0.) 
            // We can get the Clockwork Assault Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
            return !(player.itemAnimation < item.useAnimation - 2);
        }

        
        
    }
}