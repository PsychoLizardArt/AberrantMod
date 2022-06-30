using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Pets
{
    public class KingFluffyProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("King Fluffy");
            Main.projFrames[Projectile.type] = 10;
            Main.projPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.MiniMinotaur);
            base.AIType = ProjectileID.MiniMinotaur;
            base.DrawOriginOffsetY = 2;

            Projectile.scale = 1f;
            Projectile.width = 58;
            Projectile.height = 38;


           /* projectile.penetrate = -1;
            projectile.netImportant = true;
            projectile.timeLeft *= 5;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;*/
        }

       
        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.miniMinotaur = false;
            return true;
        }
        public override void AI()
        {
            Player player = Main.player[Projectile.owner];

            if (!player.dead && player.HasBuff(ModContent.BuffType<CatsPetBuff>())) 
            {
                Projectile.timeLeft = 2;
            }
          
        }

    }
}
