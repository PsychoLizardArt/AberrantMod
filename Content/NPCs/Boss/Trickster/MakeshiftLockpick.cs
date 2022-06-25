using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AberrantMod.Content.NPCs.Boss.Trickster
{
    public class MakeshiftLockpick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Makeshift Lockpick");
            Tooltip.SetDefault("Lets loose a criminal demonic entity" +
                                 "\nSummons the Trickster when used in the dungeon" +
                                "\nNot consumable");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 30;
            item.maxStack = 1;
            item.rare = 3;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
            item.consumable = false;

        }

        public override bool CanUseItem(Player player)
        {
            return !NPC.AnyNPCs(mod.NPCType("Trickster")) && player.ZoneDungeon;
        }


        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Trickster"));
            Main.PlaySound(SoundID.NPCDeath10, player.position);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bone, 20);
            recipe.AddIngredient(ItemID.GoldenKey, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
