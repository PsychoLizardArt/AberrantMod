using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Aberrant.Content.NPCs.Town
{
    [AutoloadHead]

    public class Toko : ModNPC
    {

        public override string Texture
        {
            get { return "Aberrant/AberrantNPCs/Toko"; } //texture file
        }

        public override bool Autoload(ref string name)
        {
            name = "Devil"; //npc title
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 23;
            NPCID.Sets.ExtraFramesCount[npc.type] = 8;
            NPCID.Sets.AttackFrameCount[npc.type] = 3;
            NPCID.Sets.DangerDetectRange[npc.type] = 500;
            NPCID.Sets.AttackType[npc.type] = 2;
            NPCID.Sets.AttackTime[npc.type] = 30;
            NPCID.Sets.AttackAverageChance[npc.type] = 10;
            NPCID.Sets.HatOffsetY[npc.type] = 0;
        }

        


        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 42;

            npc.aiStyle = 7;
            npc.damage = 5;
            npc.defense = 50;
            npc.lifeMax = 1800;
            npc.HitSound = SoundID.NPCHit27;
            npc.DeathSound = SoundID.NPCDeath30;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Clothier; //can make custom animaton, search up how
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

        public override string TownNPCName() //npc name (only toko lmao)
        {
            switch (WorldGen.genRand.Next(1))
            {
                default:
                    return "Toko";
            }

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
                Main.LocalPlayer.AddBuff(mod.BuffType("FriendlyHex"), 54000);
                Main.LocalPlayer.AddBuff(mod.BuffType("Hellfire"), 600);
                Main.PlaySound(SoundID.Item74);
            
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot) //shop
        {
            shop.item[nextSlot].SetDefaults(mod.ItemType("MorselRadiant"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(mod.ItemType("MorselUmbral"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(mod.ItemType("MorselSanguine"));
            nextSlot++;

            shop.item[nextSlot].SetDefaults(ItemID.LifeCrystal);
            shop.item[nextSlot].value = Item.buyPrice(0, 7, 50, 0);
            nextSlot++;

            shop.item[nextSlot].SetDefaults(ItemID.ManaCrystal);
            shop.item[nextSlot].value = Item.buyPrice(0, 7, 50, 0);
            nextSlot++;

            if(Main.bloodMoon)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("BloodContract"));
                nextSlot++;
            }

            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("HerbalCluster"));
                nextSlot++;

                shop.item[nextSlot].SetDefaults(mod.ItemType("TricksterHandbook"));
                nextSlot++;

                shop.item[nextSlot].SetDefaults(mod.ItemType("TricksterTomahawk"));
                nextSlot++;

                shop.item[nextSlot].SetDefaults(mod.ItemType("TricksterBow"));
                nextSlot++;
            }

            if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.LifeFruit);
                shop.item[nextSlot].value = Item.buyPrice(0, 15, 0, 0);
                nextSlot++;
            }
        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), ItemID.Blindfold); 
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
    }
}       
        
