using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;


namespace Aberrant.Content.Items.Consumables
{
    public class MorselRadiant : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.maxStack = 9999;
            item.rare = 2;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useStyle = 2;
            item.UseSound = SoundID.Item2;
            item.consumable = true;
            item.value = Item.buyPrice(0, 5, 0, 0);
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Radiant Morsel");
            Tooltip.SetDefault("Where does Toko even get these?" +
                                "\nSets time to day upon consumption");
        }

        public override bool CanUseItem(Player player)
        {
            if (!Main.dayTime)
                return true;
            return false;
        }

        public override bool UseItem(Player player)
        {
            Main.dayTime = true;
            Main.time = 0.0;
            Main.NewText("The world is blessed with sunshine...", 255, 240, 20);
            return true;
        }


    }
}