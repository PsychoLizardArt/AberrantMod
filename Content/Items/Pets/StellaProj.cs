using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AberrantMod;

namespace AberrantMod.Content.Items.Pets
{
    public class StellaProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stella");
            Main.projFrames[Projectile.type] = 1;
            Main.projPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.CompanionCube);
            base.AIType = ProjectileID.CompanionCube;
            base.DrawOriginOffsetY = 2;

            Projectile.width = 46;
            Projectile.height = 38;

            Projectile.scale = 1f;

            Projectile.ignoreWater = true;
        

            Projectile.friendly = true;


          /*  projectile.penetrate = -1;
            projectile.netImportant = true;
            projectile.timeLeft *= 5;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;

            projectile.aiStyle = ProjectileID.CompanionCube;*/
        }

        
        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.companionCube = false;
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
