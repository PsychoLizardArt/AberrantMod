using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Pets
{
    public class MonsterProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Monster");
            Main.projFrames[Projectile.type] = 2;
            Main.projPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.BabyEater);
            base.AIType = ProjectileID.BabyEater;
            //base.drawOriginOffsetY = 0;

            Projectile.height = 46;
            Projectile.width = 40;

            Projectile.scale = 1f;

            /*projectile.width = 46;
            projectile.height = 40;

            projectile.penetrate = -1;
            projectile.netImportant = true;
            projectile.timeLeft *= 5;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;*/
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];
            player.eater = false;
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
