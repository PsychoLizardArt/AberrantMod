using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items.Weapons.Ranged;
public class TricksterBow : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("King");
        // Tooltip.SetDefault("Transforms one arrow into three");
    }
    public override void SetDefaults()
    {
        Item.width = 40;
        Item.height = 70;

        Item.useStyle = ItemUseStyleID.Shoot;
        Item.UseSound = SoundID.Item101 with { Volume = 0.8f, Pitch = 0.5f, PitchVariance = 0.1f };

        Item.DamageType = DamageClass.Ranged;
        Item.damage = 19;
        Item.knockBack = 3f;
        Item.useTime = 6;
        Item.useAnimation = 18;
        Item.autoReuse = true;
        Item.reuseDelay = 12;

        Item.noMelee = true;

        Item.useAmmo = AmmoID.Arrow;
        Item.consumeAmmoOnLastShotOnly = true;
        Item.shoot = 10;
        Item.shootSpeed = 10f;

        Item.rare = ItemRarityID.Orange;
        //Item.value = Item.sellPrice(gold: 12);
    }
    public override Vector2? HoldoutOffset()
    {
        return new Vector2(-6f, 0f);
    }
}