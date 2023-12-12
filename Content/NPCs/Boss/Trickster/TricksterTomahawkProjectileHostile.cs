using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.NPCs.Boss.Trickster;
public class TricksterTomahawkProjectileHostile : ModProjectile
{
    public override string Texture => "AberrantMod/Content/Items/Weapons/Melee/TricksterTomahawk";
    public override void SetDefaults()
    {
        Projectile.aiStyle = 3;
        Projectile.width = 38;
        Projectile.height = 38;
        Projectile.friendly = false;
        Projectile.hostile = true;
        Projectile.penetrate = -1;
        Projectile.tileCollide = false;
        Projectile.ignoreWater = true;
        Projectile.maxPenetrate = -1;
        Projectile.extraUpdates = 1;
        Projectile.alpha = 255;
    }
    public override void AI()
    {
        Projectile.spriteDirection = Projectile.direction;
        Dust dustTrail;
        dustTrail = Main.dust[Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.HeatRay, Projectile.velocity.X * 0.25f, Projectile.velocity.Y * 0.25f, 0, default(Color), 1f)]; dustTrail.noGravity = true; 
    }
}