using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;


namespace AberrantMod.Content.Buffs
{
    public class FriendlyHex : ModBuff
    {


        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Friendly Hex");
            Description.SetDefault("Slightly increased movement speed and damage");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetDamage(DamageClass.Generic) += 0.05f;
            player.moveSpeed += 0.1f;
            player.runAcceleration += 0.1f;
        }
    }
}
