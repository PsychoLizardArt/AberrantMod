using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Aberrant;

namespace Aberrant.Content.Items.Pets
{
    public class CatsPetBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Triple Trouble");
            Description.SetDefault("Stella, Monster, and King Fluffy are following you");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<AberrantModPlayer>().catsPet = true;
            bool stellaPetProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("StellaProj")] <= 0;
            bool monsterPetProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("MonsterProj")] <= 0;
            bool kingfluffyPetProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("KingFluffyProj")] <= 0;
            if (stellaPetProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("StellaProj"), 0, 0f, player.whoAmI, 0f, 0f);
            }
            
            if (monsterPetProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("MonsterProj"), 0, 0f, player.whoAmI, 0f, 0f);
            }

            if (kingfluffyPetProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("KingFluffyProj"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}
