using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aberrant.Content.Items.Consumables
{
    public class MorselSanguine : ModItem
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
            item.value = Item.buyPrice(0, 10, 0, 0);
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sanguine Morsel");
            Tooltip.SetDefault("Where does Toko even get these?" +
                                "\nSummons the Blood Moon upon consumption");
        }

        public override bool CanUseItem(Player player)
        {
            if (!Main.dayTime && !Main.bloodMoon)
                return true;
            return false;
        }

        public override bool UseItem(Player player)
        {
            Main.bloodMoon = true;
            Main.NewText("The Blood Moon is rising...", 50, 255, 130);
            return true;
        }


    }
}