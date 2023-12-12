using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace AberrantMod.Content.Items.Weapons.Melee;
public class WatchfulClaw : ModItem
{
    public override void SetStaticDefaults()
    {
        // DisplayName.SetDefault("Phaser Blades");
    }
    public override void SetDefaults()
    {
        Item.width = 30;
        Item.height = 34;
        Item.scale += 0.5f;

        Item.useStyle = ItemUseStyleID.Swing;
        Item.UseSound = SoundID.Item1 with { Volume = 0.8f, Pitch = 0.8f, PitchVariance = 0f, MaxInstances = 16, SoundLimitBehavior = SoundLimitBehavior.IgnoreNew };

        Item.DamageType = DamageClass.Melee;
        Item.damage = 10;
        Item.knockBack = 1f;
        Item.useTime = 7;
        Item.useAnimation = 7;
        Item.autoReuse = true;
        Item.useTurn = false;

        Item.rare = ItemRarityID.Blue;
        //Item.value = Item.sellPrice(gold:1);
    }
    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient<NeuronicBar>(8)
        .AddTile(TileID.Anvils)
        .Register();
    }
    /*public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale)
    {
        
    }*/
    /*public override void PostDrawInWorld(SpriteBatch spriteBatch, Color lightColor, Color alphaColor, float rotation, float scale, int whoAmI)
    {
        Texture2D texture = ModContent.Request<Texture2D>("ModSources/AberrantMod/Content/Items/Weapons/Melee/WatchfulClaw_Glow", AssetRequestMode.ImmediateLoad).Value;
        spriteBatch.Draw
        (
            texture,
            new Vector2
            (
                Item.position.X - Main.screenPosition.X + Item.width * 0.5f,
                Item.position.Y - Main.screenPosition.Y + Item.height - texture.Height * 0.5f + 2f
            ),
            new Rectangle(0, 0, texture.Width, texture.Height),
            Color.White,
            rotation,
            texture.Size() * 0.5f,
            scale,
            SpriteEffects.None,
            0f
        );
    }*/
    public override void MeleeEffects(Player player, Rectangle hitbox)
    {
        if (Main.rand.NextBool(2))
        {
            Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, DustID.Torch);
            return;
        }
        Lighting.AddLight(Item.Center, 255, 213, 128);
    }
}