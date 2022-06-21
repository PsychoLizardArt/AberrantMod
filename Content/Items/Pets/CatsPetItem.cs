using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aberrant.Content.Items.Pets
{
    public class CatsPetItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frisky Temptation");
            Tooltip.SetDefault("Summons a mischievous trio");
        }

        public override void SetDefaults()
        {
            item.shoot = mod.ProjectileType("StellaProj");
            item.shoot = mod.ProjectileType("MonsterProj");
            item.shoot = mod.ProjectileType("KingFluffyProj");

            item.buffType = mod.BuffType("CatsPetBuff");

            item.damage = 0;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item2;
            item.useAnimation = 20;
            item.useTime = 20;
            item.noMelee = true;

            item.rare = 2;
            item.value = Item.buyPrice(0, 5, 0, 0);

            item.width = 26;
            item.height = 32;
        }

        public override void UseStyle(Player player)
        {
            if(player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Tuna, 5);
            recipe.AddIngredient(ItemID.BottledHoney, 5);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.CookingPots);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
        
    
}