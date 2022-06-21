using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Aberrant.Content.Buffs
{
    public class FriendlyHex : ModBuff
    {


        public override void SetDefaults()
        {
            DisplayName.SetDefault("Friendly Hex");
            Description.SetDefault("10% increased movement speed and 5% increased damage");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.05f;
            player.rangedDamage += 0.05f;
            player.magicDamage += 0.05f;
            player.minionDamage += 0.05f;
            player.thrownDamage += 0.05f;
            player.moveSpeed += 0.1f;
        }
    }
}
