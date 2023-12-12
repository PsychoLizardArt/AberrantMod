using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Armor.WatchfulArmor;
[AutoloadEquip(EquipType.Body)]
public class WatchfulAegis : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Watchful Aegis");
        // Tooltip.SetDefault("Slowly regenerates life");
    }
    public override void SetDefaults()
    {
        Item.width = 32;
        Item.height = 20;
        Item.defense = 5;
        Item.rare = ItemRarityID.Blue;
        //Item.value = Item.sellPrice();
    }
    public override void UpdateEquip(Player player)
    {
        player.lifeRegen++;
    }
    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient<NeuronicBar>(12).AddTile(TileID.Anvils)
            .Register();
    }
}