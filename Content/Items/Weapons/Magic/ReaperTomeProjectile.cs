using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Audio;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items.Weapons.Magic;
public class ReaperTomeProjectile : ModProjectile
{
    public override void SetDefaults()
    {
        Projectile.width = 106;
        Projectile.height = 106;
        Projectile.friendly = true;
        Projectile.penetrate = -1;
        Projectile.tileCollide = false;
    }
    public override void AI()
    {
        Vector2 position = Projectile.Center;
        Lighting.AddLight(Projectile.Center, 0f, 1f, 0f);
        Player player = Main.player[Projectile.owner];
        bool hasMana = player.CheckMana(1);
        Vector2 followCursor = Main.MouseWorld - Projectile.Center;
        Projectile.spriteDirection = Projectile.direction;
        Projectile.rotation += Projectile.spriteDirection * 0.35f;
        Projectile.velocity = followCursor * 0.03f;
        if (Main.myPlayer == Projectile.owner)
        {
            if (player.channel && hasMana)
            {
                player.statMana -= 1;
                player.manaRegenDelay = (int)player.maxRegenDelay;
                Projectile.ai[0]++;
                if (Projectile.ai[0] > 15)
                {
                    SoundEngine.PlaySound(SoundID.Item71 with { Volume = 0.5f, Pitch = 0.5f, PitchVariance = 0.2f, MaxInstances = 8, SoundLimitBehavior = SoundLimitBehavior.IgnoreNew }, Projectile.Center);
                    Dust trailDust;
                    trailDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.GreenFairy, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                    Projectile.ai[0] = 0;
                    Projectile.timeLeft = 600;
                }
                return;
            }
            else
            {
                SoundEngine.PlaySound(SoundID.Item29 with { Volume = 0.5f, Pitch = 0.3f }, Projectile.Center);
                Dust killDust;
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                killDust = Main.dust[Dust.NewDust(position, 0, 0, DustID.PortalBoltTrail, 0f, 0f, 0, new Color(0, 255, 0), 1f)];
                Projectile.Kill();
                return;
            }
        }
    }
}