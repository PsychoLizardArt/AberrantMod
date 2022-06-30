using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AberrantMod.Content.Items.Pets
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
            Item.shoot = Mod.Find<ModProjectile>("StellaProj").Type;
            Item.shoot = Mod.Find<ModProjectile>("MonsterProj").Type;
            Item.shoot = Mod.Find<ModProjectile>("KingFluffyProj").Type;

            Item.buffType = Mod.Find<ModBuff>("CatsPetBuff").Type;

            Item.damage = 0;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item2;
            Item.useAnimation = 20;
            Item.useTime = 20;
            Item.noMelee = true;

            Item.rare = 2;
            Item.value = Item.buyPrice(0, 5, 0, 0);

            Item.width = 26;
            Item.height = 32;
        }

        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {
            if(player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(Item.buffType, 3600, true);
            }
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Tuna, 5);
            recipe.AddIngredient(ItemID.BottledHoney, 5);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddTile(TileID.CookingPots);
            recipe.Register();
        }
    }
        
    
}
