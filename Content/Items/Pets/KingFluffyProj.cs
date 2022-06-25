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
            Main.projFrames[projectile.type] = 10;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.MiniMinotaur);
            base.aiType = ProjectileID.MiniMinotaur;
            base.drawOriginOffsetY = 2;

            projectile.scale = 1f;
            projectile.width = 58;
            projectile.height = 38;


           /* projectile.penetrate = -1;
            projectile.netImportant = true;
            projectile.timeLeft *= 5;
            projectile.friendly = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;*/
        }

       
        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.miniMinotaur = false;
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
