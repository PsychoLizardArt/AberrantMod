using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Consumables
{
    public class MorselSanguine : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.maxStack = 9999;
            Item.rare = 2;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useStyle = 2;
            Item.UseSound = SoundID.Item2;
            Item.consumable = true;
            Item.value = Item.buyPrice(0, 10, 0, 0);
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

        public override bool? UseItem(Player player)/* tModPorter Suggestion: Return null instead of false */
        {
            Main.bloodMoon = true;
            Main.NewText("The Blood Moon is rising...", 50, 255, 130);
            return true;
        }


    }
}
