using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items.Pets.CatsPet;
public class CatsPetBuff : ModBuff
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Triple Trouble");
        // Description.SetDefault("Stella, Monster, and King Fluffy are following you");
        Main.buffNoTimeDisplay[Type] = true;
        Main.vanityPet[Type] = true;
    }
    public override void Update(Player player, ref int buffIndex)
    {
        player.buffTime[buffIndex] = 18000;
        bool stellaNotSpawned = player.ownedProjectileCounts[Mod.Find<ModProjectile>("Stella").Type] <= 0;
        bool monsterNotSpawned = player.ownedProjectileCounts[Mod.Find<ModProjectile>("Monster").Type] <= 0;
        bool kingFluffyNotSpawned = player.ownedProjectileCounts[Mod.Find<ModProjectile>("KingFluffy").Type] <= 0;

        if (stellaNotSpawned && player.whoAmI == Main.myPlayer) {
            Projectile.NewProjectile(player.GetSource_Buff(buffIndex), player.Center, Vector2.Zero, Mod.Find<ModProjectile>("Stella").Type, 0, 0f, player.whoAmI, 0f, 0f); 
        }
        if(monsterNotSpawned && player.whoAmI == Main.myPlayer) {
            Projectile.NewProjectile(player.GetSource_Buff(buffIndex), player.Center, Vector2.Zero, Mod.Find<ModProjectile>("Monster").Type, 0, 0f, player.whoAmI, 0f, 0f); 
        }
        if (kingFluffyNotSpawned && player.whoAmI == Main.myPlayer) {
            Projectile.NewProjectile(player.GetSource_Buff(buffIndex), player.Center, Vector2.Zero, Mod.Find<ModProjectile>("KingFluffy").Type, 0, 0f, player.whoAmI, 0f, 0f); 
        }
    }
}
