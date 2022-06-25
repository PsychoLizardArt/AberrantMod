using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics;
using Aberrant;

namespace AberrantMod.Content.NPCs.Boss.Trickster
{
    [AutoloadBossHead]

    public class Trickster : ModNPC
    {
        //AI
        private int ai;
        private int attackTimer = 0;
        private bool fastSpeed = false;

        private bool stunned;
        private int stunnedTimer;


        //animation
        private int frame = 0;
        private double counting;


        public override string Texture
        {
            get { return "Aberrant/AberrantNPCs/Bosses/TricksterBoss/Trickster"; } //texture file 
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Trickster");
            Main.npcFrameCount[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.lifeMax = 6200;
            npc.damage = 20;
            npc.defense = 50;
            npc.knockBackResist = 0f;
            npc.width = 40;
            npc.height = 80;

            npc.value = Item.buyPrice(gold: 50);

            npc.boss = true;
            npc.aiStyle = -1;
            npc.npcSlots = 15f;

            npc.noTileCollide = true;
            npc.noGravity = true;
            npc.lavaImmune = true;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;

            music = MusicID.Boss2;

            bossBag = mod.ItemType("TricksterBag");

            npc.buffImmune[24] = true;
        }

        //expert mode stats
        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * bossLifeScale);
            npc.damage = (int)(npc.damage * 1.3f);
        }

        //animation frames. frame == 0 is arm down. frame == 1 is arm up
        public override void FindFrame(int frameHeight)
        {
            if (frame == 0)
            {
                counting += 1.0;
                if (counting < 8.0)
                {
                    npc.frame.Y = 0;
                }
                else if (counting < 16.0)
                {
                    npc.frame.Y = frameHeight;
                }
                else
                {
                    counting = 0.0;
                }
            }

            if (frame == 1)
            {
                counting += 1.0;
                if (counting < 8.0)
                {
                    npc.frame.Y = frameHeight * 2;
                }
                else if (counting < 16.0)
                {
                    npc.frame.Y = frameHeight * 3;
                }
                else
                {
                    counting = 0.0;
                }
            }
        }




        //defines movetowards
        private void MoveTowards(NPC npc, Vector2 playerTarget, float speed, float turnResistance)
        {
            var move = playerTarget - npc.Center;
            float length = move.Length();
            if (length > speed)
            {
                move *= speed / length;
            }
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            length = move.Length();
            if (length > speed)
            {
                move *= speed / length;
            }
            npc.velocity = move;
        }


        public override void AI()
        {
            //player & target vector
            npc.TargetClosest(true);
            Player player = Main.player[npc.target];
            Vector2 target = npc.HasPlayerTarget ? player.Center : Main.npc[npc.target].Center;

            //ensures npc life is not greater than its max life
            if (npc.life >= npc.lifeMax)
                npc.life = npc.lifeMax;

            //despawning
            if (npc.target < 0 || npc.target == 255 || player.dead || !player.active)
            {
                npc.TargetClosest(false);
                npc.direction = 1;
                npc.velocity.Y = npc.velocity.Y - 0.1f;
                if (npc.timeLeft > 20)
                {
                    npc.timeLeft = 20;
                    return;
                }
            }

            //stunned
            if (stunned)
            {
                //npc doesnt move
                npc.velocity.X = 0.0f;
                npc.velocity.Y = 0.0f;

                //increment the timer
                stunnedTimer++;

                //no longer stunned and timer reset
                if (stunnedTimer >= 100)
                {
                    stunned = false;
                    stunnedTimer = 0;
                }
            }

            //increment ai
            ai++;

            //movement
            npc.ai[0] = (float)ai * 1f;
            int distance = (int)Vector2.Distance(target, npc.Center);
            if ((double)npc.ai[0] < 300)
            {
                frame = 0;
                MoveTowards(npc, target, (float)(distance > 300 ? 13f : 7f), 30f);
                npc.netUpdate = true;
            }
            else if ((double)npc.ai[0] >= 300 && (double)npc.ai[0] < 450.0)
            {
                stunned = true;
                frame = 1;
                npc.defense = 40;
                npc.damage = 10;
                MoveTowards(npc, target, (float)(distance > 300 ? 13f : 7f), 30f);
                npc.netUpdate = true;
            }
            npc.netUpdate = true;

            //attack













        }

                  


        





        


       







        //loot table, see TricksterBag.cs
        public override void NPCLoot()
        {
            AberrantModWorld.DownedTrickster = true;
            if(Main.expertMode)
            {
                npc.DropBossBags();
            }
            else
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, Main.rand.Next(1, 3));
                if(Main.rand.Next(2) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TricksterHandbook"), 1);
                }
            }
        }
        














    }  



}
