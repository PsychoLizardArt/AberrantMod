using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Aberrant;

namespace Aberrant.Content.Items.Pets
{
    public class StellaProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stella");
            Main.projFrames[projectile.type] = 1;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.CompanionCube);
            base.aiType = ProjectileID.CompanionCube;
            base.drawOriginOffsetY = 2;

            projectile.width = 46;
            projectile.height = 38;

            projectile.scale = 1f;

            projectile.ignoreWater = true;
        

            projectile.friendly = true;


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
            Player player = Main.player[projectile.owner];
            player.companionCube = false;
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