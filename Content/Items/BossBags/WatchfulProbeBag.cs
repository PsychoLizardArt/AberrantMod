using AberrantMod.Content.Items.Accessories;
using AberrantMod.Content.NPCs.Boss.WatchfulProbe;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.BossBags;
public class WatchfulProbeBag : BossBag
{
    protected override bool IsPreHMBag => true;
    public int BossBagNPC => ModContent.NPCType<WatchfulProbe>();
    public void OpenBossBag(Player player)
    {
        player.QuickSpawnItem(player.GetSource_OpenItem(Item.type), ModContent.ItemType<TricksterHandbook>());
    }
}
