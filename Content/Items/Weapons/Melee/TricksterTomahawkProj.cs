using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Weapons.Melee
{
    public class TricksterTomahawkProj : ModProjectile
    {
  
        public override void SetDefaults()
        {
            Projectile.CloneDefaults(301);
            AIType = 301;

            Projectile.width = 44;
            Projectile.height = 44;

            Projectile.aiStyle = 3;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.DamageType = DamageClass.Melee;
            Projectile.scale = 1f;

            Projectile.extraUpdates = 2;
            Projectile.tileCollide = false;

          
        }

    }
}
