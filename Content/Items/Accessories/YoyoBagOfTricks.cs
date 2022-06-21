using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Aberrant.Content.Items.Accessories
{
    public class YoyoBagOfTricks : ModItem //post-golem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yoyo Bag of Tricks");
            Tooltip.SetDefault("Gives the user master yoyo skills" +
                                "\nAllows the ability to climb walls and dash" +
                                "\nGives a chance to dodge attacks" +
                                "\nGrants immunity to knockback" +
                                "\n10% increased movement speed" +
                                "\n10% increased melee damage");
        }

        public override void SetDefaults()
        {
            item.width = 42;
            item.height = 44;
            item.accessory = true;
            item.value = Item.buyPrice(0, 20, 0, 0);
            item.rare = 7;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.YoyoBag, 1);
            recipe.AddIngredient(ItemID.MasterNinjaGear, 1);
            recipe.AddIngredient(mod.ItemType("TricksterHandbook"), 1);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
            recipe.AddIngredient(ItemID.BeetleHusk, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateEquip(Player player)
        {
            player.dash = 1;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.counterWeight = ProjectileID.BlackCounterweight + Main.rand.Next(6);
            player.yoyoGlove = true;
            player.yoyoString = true;
            player.noKnockback = true;
            player.blackBelt = true;
            player.moveSpeed += 0.1f;
            player.runAcceleration += 0.1f;
            player.meleeDamage += 0.1f;
        }
    }
}