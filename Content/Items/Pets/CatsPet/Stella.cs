using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items.Pets.CatsPet;
public class Stella : ModProjectile
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Stella");
        Main.projFrames[Projectile.type] = 1;
        Main.projPet[Projectile.type] = true;
    }
    public override void SetDefaults()
    {
        Projectile.CloneDefaults(653);
        AIType = 653;
        DrawOriginOffsetY = 2;
        Projectile.scale = 1f;
        Projectile.width = 46;
        Projectile.height = 38;
    }
    public override bool PreAI()
    {
        Main.player[Projectile.owner].companionCube = false;
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