using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items.Weapons.Melee;
public class TricksterTomahawk : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Bishop");
    }
    public override void SetDefaults()
    {
        Item.width = 48;
        Item.height = 42;

        Item.useStyle = ItemUseStyleID.Swing;
        Item.UseSound = SoundID.Item1 with { Pitch = 0.5f, PitchVariance = 0.1f };

        Item.DamageType = DamageClass.Melee;
        Item.damage = 34;
        Item.knockBack = 5f;
        Item.useTime = 15;
        Item.useAnimation = 15;
        Item.autoReuse = true;
        Item.useTurn = false;
        Item.reuseDelay = 5;

        Item.noMelee = true;
        Item.noUseGraphic = true;

        Item.shoot = Mod.Find<ModProjectile>("TricksterTomahawkProjectile").Type;
        Item.shootSpeed = 10f;

        Item.rare = ItemRarityID.Orange;
        //Item.value = Item.sellPrice(gold: 12);
    }
}