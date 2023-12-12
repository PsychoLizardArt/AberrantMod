using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace AberrantMod.Content.Items.Weapons.Magic;
public class ReaperTome : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Tome of the Throne");
    }
    public override void SetDefaults()
    {
        Item.width = 40;
        Item.height = 44;

        Item.useStyle = ItemUseStyleID.Shoot;
        Item.UseSound = SoundID.Item71;

        Item.DamageType = DamageClass.Magic;
        Item.damage = 75;
        Item.knockBack = 2f;
        Item.useTime = 30;
        Item.useAnimation = 30;

        Item.noMelee = true;
        Item.channel = true;

        Item.mana = 10;
        Item.shoot = Mod.Find<ModProjectile>("ReaperTomeProjectile").Type;
        Item.shootSpeed = 10f;

        Item.rare = ItemRarityID.Lime;
        //Item.value = ;
    }
}
