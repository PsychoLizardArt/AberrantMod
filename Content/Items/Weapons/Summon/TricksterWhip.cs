using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items.Weapons.Summon;
public class TricksterWhip : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("");
    }
    public override void SetDefaults()
    {
        Item.DamageType = DamageClass.SummonMeleeSpeed;
        Item.damage = 20;
        Item.knockBack = 2;
        Item.rare = ItemRarityID.Orange;

        Item.shoot = ModContent.ProjectileType<TricksterWhipProjectile>();
        Item.shootSpeed = 5;

        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTime = 16;
        Item.useAnimation = 16;
        Item.UseSound = SoundID.Item152;
        Item.noMelee = true;
        Item.noUseGraphic = true;
    }
    public override bool MeleePrefix()
    {
        return true;
    }
}