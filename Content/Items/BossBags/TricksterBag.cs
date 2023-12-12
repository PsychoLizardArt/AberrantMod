using AberrantMod.Content.Items.Accessories;
using AberrantMod.Content.NPCs.Boss.Trickster;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using AberrantMod.Content.Items.BossBags;

namespace AberrantMod.Content.Items.BossBags;
public class TricksterBag : BossBag
{
    protected override bool IsPreHMBag => true;
    public int BossBagNPC => ModContent.NPCType<Trickster>();
    public void OpenBossBag(Player player)
    {
        player.QuickSpawnItem(player.GetSource_OpenItem(Item.type), ModContent.ItemType<TricksterHandbook>());
    }
}
