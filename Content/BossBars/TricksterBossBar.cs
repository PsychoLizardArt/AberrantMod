using Terraria;
using Terraria.ID;
using Terraria.GameContent;
using Terraria.ModLoader;
using Terraria.GameContent.UI.BigProgressBar;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using AberrantMod.Content.NPCs.Boss.Trickster;

using ReLogic.Content;

namespace AberrantMod.Content.BossBars;
public class TricksterBossBar : ModBossBar
{
    private int bossHeadIndex = -1;
    public override Asset<Texture2D> GetIconTexture(ref Rectangle? iconFrame)
    {
        if (bossHeadIndex != -1)
        {
            return TextureAssets.NpcHeadBoss[bossHeadIndex];
        } return null;
    }
}