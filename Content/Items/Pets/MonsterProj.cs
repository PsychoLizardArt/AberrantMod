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
            Main.projFrames[projectile.type] = 2;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.BabyEater);
            base.aiType = ProjectileID.BabyEater;
            //base.drawOriginOffsetY = 0;

            projectile.height = 46;
            projectile.width = 40;

            projectile.scale = 1f;

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
            Player player = Main.player[projectile.owner];
            player.eater = false;
            return true;
        }
        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            AberrantModPlayer modPlayer = player.GetModPlayer<AberrantModPlayer>();
            if (player.dead)
            {
                modPlayer.catsPet = false;
            }
            if (modPlayer.catsPet)
            {
                projectile.timeLeft = 2;
            }
        }

    }
}
