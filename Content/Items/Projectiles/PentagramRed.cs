using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Projectiles
{
    public class PentagramRed : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Phantom Rune");
        }

        public override void SetDefaults()
        {
            projectile.width = 49;
            projectile.height = 49;
            projectile.aiStyle = 115;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.timeLeft = 180;
            projectile.alpha = 100;
            projectile.light = 1;
            

     
     
        }

       




    }
        

}
