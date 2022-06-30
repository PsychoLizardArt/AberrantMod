using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Buffs
{
    public class Hellfire : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellfire");
            Description.SetDefault("You are being punished");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen -= 12;
            player.endurance -= 0.25f;
        }
    }
}
