using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Armor.WatchfulArmor;
[AutoloadEquip(EquipType.Head)]
public class WatchfulVisageMelee : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Watchful Sentry Visage");
        // Tooltip.SetDefault("10% increased melee damage");
        ArmorIDs.Head.Sets.DrawHead[Item.headSlot] = false;
    }
    public override void SetDefaults()
    {
        Item.width = 24;
        Item.height = 24;
        Item.defense = 4;
        Item.rare = ItemRarityID.Blue;
        //Item.value = Item.sellPrice();
    }
    public override void UpdateEquip(Player player)
    {
        player.GetDamage(DamageClass.Melee) += 0.1f;
    }
    public override bool IsArmorSet(Item head, Item body, Item legs)
    {
        return body.type == ModContent.ItemType<WatchfulAegis>() && legs.type == ModContent.ItemType<WatchfulGreaves>();
    }
    public override void UpdateArmorSet(Player player)
    {
        player.setBonus = "5% increased critical strike chance\nGrants night vision";
        player.nightVision = true;
        player.GetCritChance(DamageClass.Generic) += 0.05f;
    }
    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient<NeuronicBar>(6).AddTile(TileID.Anvils)
            .Register();
    }
}