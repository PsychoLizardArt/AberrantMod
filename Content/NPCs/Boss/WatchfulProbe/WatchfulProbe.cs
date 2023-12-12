using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.NPCs.Boss.WatchfulProbe;
[AutoloadBossHead]
public class WatchfulProbe : ModNPC
{
    public override string Texture => "AberrantMod/Content/NPCs/Boss/WatchfulProbe/WatchfulProbe";
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Watchful Probe");
        Main.npcFrameCount[NPC.type] = 6;
    }
    public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
    {
        
    }
    public override void SetDefaults()
    {
        
    }
    public override void FindFrame(int frameHeight)
    {
        
    }
}