using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.GameContent;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using System;
using ReLogic.Content;
using Terraria.GameContent.Personalities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Collections.Generic;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.DataStructures;


namespace AberrantMod.Content.NPCs.Town.Toko
{
    [AutoloadHead]

    public class Toko : ModNPC
    {

        public override string Texture
        {
            get { return "AberrantMod/Content/NPCs/Town/Toko/Toko"; } //texture file
        }

      
       

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Devil");

            Main.npcFrameCount[NPC.type] = 23;
            NPCID.Sets.ExtraFramesCount[NPC.type] = 8;
            NPCID.Sets.AttackFrameCount[NPC.type] = 3;

            NPCID.Sets.DangerDetectRange[NPC.type] = 500;
            NPCID.Sets.AttackType[NPC.type] = 2;
            NPCID.Sets.AttackTime[NPC.type] = 30;
            NPCID.Sets.AttackAverageChance[NPC.type] = 10;
            NPCID.Sets.HatOffsetY[NPC.type] = 0;

            NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                Velocity = 1f,
                Direction = -1
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, drawModifiers);

            NPC.Happiness
                .SetBiomeAffection<UndergroundBiome>(AffectionLevel.Love)
                .SetBiomeAffection<DesertBiome>(AffectionLevel.Like)
                .SetBiomeAffection<SnowBiome>(AffectionLevel.Hate)
                .SetNPCAffection(NPCID.WitchDoctor, AffectionLevel.Like)
                .SetNPCAffection(NPCID.Clothier, AffectionLevel.Like)
                .SetNPCAffection(NPCID.Wizard, AffectionLevel.Like)
                .SetNPCAffection(NPCID.Cyborg, AffectionLevel.Hate);

        }

        


        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 18;
            NPC.height = 42;

            NPC.aiStyle = 7;
            NPC.damage = 5;
            NPC.defense = 50;
            NPC.lifeMax = 1800;
            NPC.HitSound = SoundID.NPCHit27;
            NPC.DeathSound = SoundID.NPCDeath30;
            NPC.knockBackResist = 0.5f;
            AnimationType = NPCID.Clothier; //can make custom animaton, search up how
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.TheUnderworld,

                new FlavorTextBestiaryInfoElement("The Devil appears to be a lizard-like creature afflicted by a demonic curse. He calls himself Toko. Despite his unfriendly appearance, he is here to help you. But his wares seem...strangely suspicious.")

            });
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money) //spawn conditions
        {
            if (NPC.downedBoss1)
            {
                return true;
            }
            return false;
        }

        public override bool CheckConditions(int left, int right, int top, int bottom) //Allows you to define special conditions required for this town NPC's house
        {
            return true; //so when a house is available the npc will spawn
        }

        public override List<string> SetNPCNameList()
        {
            return new List<string>
            {
                "Toko",
            };
        }

    

        public override string GetChat() //dialogue options
        {
            switch (Main.rand.Next(13))
            {
                case 0:
                    return "Who do you want dead?";
                case 1:
                    return "I sense you are troubled.";
                case 2:
                    return "This world holds many sinners.";
                case 3:
                    return "These eyes are not my own.";
                case 4:
                    return "No, I will not wear the maid outfit.";
                case 5:
                    return "I am not your Devil.";
                case 6:
                    return "Don't be afraid. I can help you.";
                case 7:
                    return "Want a Hex? It will only hurt a little.";
                case 8:
                    return "Looking for a Hex?";
                case 9:
                    return "Try my Hex. Trust.";
                case 10:
                    return "Do you trust me? Try my Hex.";
                case 11:
                    return "Someone once told me I was a twink. I don't know what that means.";
                default:
                    return "Allow me to help you.";
            }

        }

        public override void SetChatButtons(ref string button, ref string button2) //third option in npc menu "hex" make it give the player a buff when they use it, 10 mins?
        {
            button = Language.GetTextValue("LegacyInterface.28");
            button2 = "Hex";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
            else
            {
                Main.npcChatText = "You have my blessing.";
                Main.LocalPlayer.AddBuff(Mod.Find<ModBuff>("FriendlyHex").Type, 54000);
                Main.LocalPlayer.AddBuff(Mod.Find<ModBuff>("Hellfire").Type, 600);
                SoundEngine.PlaySound(SoundID.Item74);
            
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot) //shop
        {
            shop.item[nextSlot].SetDefaults(Mod.Find<ModItem>("MorselRadiant").Type);
            nextSlot++;

            shop.item[nextSlot].SetDefaults(Mod.Find<ModItem>("MorselUmbral").Type);
            nextSlot++;

            shop.item[nextSlot].SetDefaults(Mod.Find<ModItem>("MorselSanguine").Type);
            nextSlot++;

            shop.item[nextSlot].SetDefaults(ItemID.LifeCrystal);
            shop.item[nextSlot].value = Item.buyPrice(0, 7, 50, 0);
            nextSlot++;

            shop.item[nextSlot].SetDefaults(ItemID.ManaCrystal);
            shop.item[nextSlot].value = Item.buyPrice(0, 7, 50, 0);
            nextSlot++;

            if(Main.bloodMoon)
            {
                shop.item[nextSlot].SetDefaults(Mod.Find<ModItem>("BloodContract").Type);
                nextSlot++;
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(Mod.Find<ModItem>("HerbalCluster").Type);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(Mod.Find<ModItem>("TricksterHandbook").Type);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(Mod.Find<ModItem>("TricksterTomahawk").Type);
                nextSlot++;

                shop.item[nextSlot].SetDefaults(Mod.Find<ModItem>("TricksterBow").Type);
                nextSlot++;
            }

            if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.LifeFruit);
                shop.item[nextSlot].value = Item.buyPrice(0, 15, 0, 0);
                nextSlot++;
            }
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ItemID.Blindfold, 1, 1, 1));
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 18;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 2;
            randExtraCooldown = 1;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.MonkStaffT2Ghast;
            attackDelay = 5;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 15f;
            randomOffset = 2f;
        }

        public override bool CanGoToStatue(bool toKingStatue) => true;

    }
}       
        
