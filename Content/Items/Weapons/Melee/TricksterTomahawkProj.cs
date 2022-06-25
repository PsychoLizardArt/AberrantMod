using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Weapons.Melee
{
    public class TricksterTomahawkProj : ModProjectile
    {
  
        public override void SetDefaults()
        {
            projectile.CloneDefaults(301);
            aiType = 301;

            projectile.width = 44;
            projectile.height = 44;

            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.melee = true;
            projectile.scale = 1f;

            projectile.extraUpdates = 2;
            projectile.tileCollide = false;

          
        }

    }
}
