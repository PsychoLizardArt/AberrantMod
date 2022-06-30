using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using AberrantMod;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AberrantMod.Content.Items.Pets
{
    public class CatsPetBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Triple Trouble");
            Description.SetDefault("Stella, Monster, and King Fluffy are following you");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            
            bool stellaPetProjectileNotSpawned = player.ownedProjectileCounts[Mod.Find<ModProjectile>("StellaProj").Type] <= 0;
            bool monsterPetProjectileNotSpawned = player.ownedProjectileCounts[Mod.Find<ModProjectile>("MonsterProj").Type] <= 0;
            bool kingfluffyPetProjectileNotSpawned = player.ownedProjectileCounts[Mod.Find<ModProjectile>("KingFluffyProj").Type] <= 0;

            if (stellaPetProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                var entitySource = player.GetSource_Buff(buffIndex);
                Projectile.NewProjectile(entitySource, player.Center, Vector2.Zero, Mod.Find<ModProjectile>("StellaProj").Type, 0, 0f, player.whoAmI, 0f, 0f);
            }
            
            if (monsterPetProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                var entitySource = player.GetSource_Buff(buffIndex);
                Projectile.NewProjectile(entitySource, player.Center, Vector2.Zero, Mod.Find<ModProjectile>("MonsterProj").Type, 0, 0f, player.whoAmI, 0f, 0f);
            }

            if (kingfluffyPetProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                var entitySource = player.GetSource_Buff(buffIndex);
                Projectile.NewProjectile(entitySource, player.Center, Vector2.Zero, Mod.Find<ModProjectile>("KingFluffyProj").Type, 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}
