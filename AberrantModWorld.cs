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
    public class AberrantModWorld : ModWorld
    {
        public static bool DownedTrickster = false;

        public override void Initialize()
        {
            DownedTrickster = false;
        }

        public override TagCompound Save()
        {
            var Downed = new List<string>();
            if (DownedTrickster) Downed.Add("Trickster");

            return new TagCompound
            {
                {
                    "Version", 0
                },
                {
                    "Downed", Downed
                }
            };
        }

        public override void Load(TagCompound tag)
        {
            var Downed = tag.GetList<string>("Downed");
            DownedTrickster = Downed.Contains("Trickster");
        }

        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            if(loadVersion == 0)
            {
                BitsByte flags = reader.ReadByte();
                DownedTrickster = flags[0];
            }

        }

        public override void NetSend(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = DownedTrickster;

            writer.Write(flags);
        }

        public override void NetReceive(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            DownedTrickster = flags[0];
        }
    }
}