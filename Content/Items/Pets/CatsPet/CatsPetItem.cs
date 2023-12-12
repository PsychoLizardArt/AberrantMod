using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items.Pets.CatsPet;
public class CatsPetItem : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Frisky Temptation");
        // Tooltip.SetDefault("Summons a mischievous trio");
    }
    public override void SetDefaults()
    {
        Item.shoot = Mod.Find<ModProjectile>("Stella").Type;
        Item.shoot = Mod.Find<ModProjectile>("Monster").Type;
        Item.shoot = Mod.Find<ModProjectile>("KingFluffy").Type;
        Item.buffType = Mod.Find<ModBuff>("CatsPetBuff").Type;
        Item.damage = 0;
        Item.useStyle = ItemUseStyleID.Swing;
        Item.UseSound = SoundID.Item2;
        Item.useAnimation = 20;
        Item.useTime = 20;
        Item.noMelee = true;
        Item.rare = ItemRarityID.Green;
        //Item.value = Item.buyPrice();
        Item.width = 26;
        Item.height = 32;
    }
    public override void UseStyle(Player player, Rectangle heldItemFrame)
    {
        if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
        {
            player.AddBuff(Item.buffType, 3600, true, false);
        }
    }
    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient(ItemID.Tuna, 1).AddIngredient(ItemID.BottledHoney, 1).AddIngredient(ItemID.Bone, 5).AddTile(TileID.CookingPots)
            .Register();
    }
}