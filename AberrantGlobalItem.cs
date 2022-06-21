using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Aberrant
{
    public class AberrantGlobalItem : GlobalItem
    {
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LifeCrystal);
            recipe.AddIngredient(ItemID.RegenerationPotion);
            recipe.AddIngredient(ItemID.MeteoriteBar, 5);
            recipe.SetResult(ItemID.BandofRegeneration);
            recipe.AddRecipe();
            base.AddRecipes();
        }
    }
}