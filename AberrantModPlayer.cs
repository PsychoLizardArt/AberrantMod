using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using System.IO;
using System.Collections.Generic;
using Terraria.DataStructures;
using Terraria.Localization;
using System.Threading;

namespace Aberrant
{
    public class AberrantModPlayer : ModPlayer
    {
        public bool catsPet;
        public override void ResetEffects()
        {
            catsPet = false;
        }
    }
}