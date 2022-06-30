using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Consumables
{
    public class HerbalCluster : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Exotic Herbal Cluster");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 34;
            Item.maxStack = 9999;
            Item.consumable = true;
            Item.rare = 2;
            Item.value = Item.buyPrice(0, 2, 50, 0);
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player) //lol this is broken, ask for rubix's help to fix
        {
            var entitySource = player.GetSource_OpenItem(Type);
             int dye = (Main.rand.Next(13));
            {
                switch(dye)
                {
                    case 0: 
                        player.QuickSpawnItem(entitySource, ItemID.RedHusk, Main.rand.Next(1, 2)); break;
                    case 1:
                        player.QuickSpawnItem(entitySource, ItemID.OrangeBloodroot, Main.rand.Next(1, 2)); break;
                    case 2:
                        player.QuickSpawnItem(entitySource, ItemID.YellowMarigold, Main.rand.Next(1, 2)); break;
                    case 3:
                        player.QuickSpawnItem(entitySource, ItemID.LimeKelp, Main.rand.Next(1, 2)); break;
                    case 4:
                        player.QuickSpawnItem(entitySource, ItemID.GreenMushroom, Main.rand.Next(1, 2)); break;
                    case 5:
                        player.QuickSpawnItem(entitySource, ItemID.TealMushroom, Main.rand.Next(1, 2)); break;
                    case 6:
                        player.QuickSpawnItem(entitySource, ItemID.CyanHusk, Main.rand.Next(1, 2)); break;
                    case 7:
                        player.QuickSpawnItem(entitySource, ItemID.SkyBlueFlower, Main.rand.Next(1, 2)); break;
                    case 8:
                        player.QuickSpawnItem(entitySource, ItemID.BlueBerries, Main.rand.Next(1, 2)); break;
                    case 9:
                        player.QuickSpawnItem(entitySource, ItemID.PurpleMucos, Main.rand.Next(1, 2)); break;
                    case 10:
                        player.QuickSpawnItem(entitySource, ItemID.VioletHusk, Main.rand.Next(1, 2)); break;
                    case 11:
                        player.QuickSpawnItem(entitySource, ItemID.PinkPricklyPear, Main.rand.Next(1, 2)); break;
                    default: 
                        player.QuickSpawnItem(entitySource, ItemID.BlackInk, Main.rand.Next(1, 2)); break;
                }
            } 

            if(Main.rand.Next(5) == 0)
            {
                int strange = (Main.rand.Next(4));
                {
                    switch(strange)
                    {
                        case 0:
                            player.QuickSpawnItem(entitySource, ItemID.StrangePlant1, Main.rand.Next(1, 2)); break;
                        case 1:
                            player.QuickSpawnItem(entitySource, ItemID.StrangePlant2, Main.rand.Next(1, 2)); break;
                        case 2:
                            player.QuickSpawnItem(entitySource, ItemID.StrangePlant3, Main.rand.Next(1, 2)); break;
                        default:
                            player.QuickSpawnItem(entitySource, ItemID.StrangePlant4, Main.rand.Next(1, 2)); break;
                    }
                }
            }
        }
    }
}

