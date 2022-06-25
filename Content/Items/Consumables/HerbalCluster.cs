using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aberrant.Content.Items.Consumables
{
    public class HerbalCluster : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Exotic Herbal Cluster");
            Tooltip.SetDefault("<right> to open");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 34;
            item.maxStack = 9999;
            item.consumable = true;
            item.rare = 2;
            item.value = Item.buyPrice(0, 2, 50, 0);
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
             int dye = (Main.rand.Next(13));
            {
                switch(dye)
                {
                    case 0: 
                        player.QuickSpawnItem(ItemID.RedHusk, Main.rand.Next(1, 2)); break;
                    case 1:
                        player.QuickSpawnItem(ItemID.OrangeBloodroot, Main.rand.Next(1, 2)); break;
                    case 2:
                        player.QuickSpawnItem(ItemID.YellowMarigold, Main.rand.Next(1, 2)); break;
                    case 3:
                        player.QuickSpawnItem(ItemID.LimeKelp, Main.rand.Next(1, 2)); break;
                    case 4:
                        player.QuickSpawnItem(ItemID.GreenMushroom, Main.rand.Next(1, 2)); break;
                    case 5:
                        player.QuickSpawnItem(ItemID.TealMushroom, Main.rand.Next(1, 2)); break;
                    case 6:
                        player.QuickSpawnItem(ItemID.CyanHusk, Main.rand.Next(1, 2)); break;
                    case 7:
                        player.QuickSpawnItem(ItemID.SkyBlueFlower, Main.rand.Next(1, 2)); break;
                    case 8:
                        player.QuickSpawnItem(ItemID.BlueBerries, Main.rand.Next(1, 2)); break;
                    case 9:
                        player.QuickSpawnItem(ItemID.PurpleMucos, Main.rand.Next(1, 2)); break;
                    case 10:
                        player.QuickSpawnItem(ItemID.VioletHusk, Main.rand.Next(1, 2)); break;
                    case 11:
                        player.QuickSpawnItem(ItemID.PinkPricklyPear, Main.rand.Next(1, 2)); break;
                    default: 
                        player.QuickSpawnItem(ItemID.BlackInk, Main.rand.Next(1, 2)); break;
                }
            } 

            if(Main.rand.Next(5) == 0)
            {
                int strange = (Main.rand.Next(4));
                {
                    switch(strange)
                    {
                        case 0:
                            player.QuickSpawnItem(ItemID.StrangePlant1, Main.rand.Next(1, 2)); break;
                        case 1:
                            player.QuickSpawnItem(ItemID.StrangePlant2, Main.rand.Next(1, 2)); break;
                        case 2:
                            player.QuickSpawnItem(ItemID.StrangePlant3, Main.rand.Next(1, 2)); break;
                        default:
                            player.QuickSpawnItem(ItemID.StrangePlant4, Main.rand.Next(1, 2)); break;
                    }
                }
            }
        }
    }
}

