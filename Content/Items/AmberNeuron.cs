using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace AberrantMod.Content.Items;

public class AmberNeuron : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Amber Neuron");
    }
    public override void SetDefaults()
    {
        Item.width = 30;
        Item.height = 40;
        Item.maxStack = 9999;
        Item.value = Item.sellPrice(silver:20);
        Item.rare = ItemRarityID.Blue;
    }
}