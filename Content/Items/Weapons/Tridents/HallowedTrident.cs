using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TritonsHydrants.Common;

namespace TritonsHydrants.Content.Items.Weapons.Tridents;

public class HallowedTrident : ModItem
{
    public override void SetDefaults()
    {
        // Item settings
        Item.damage = 12;
        Item.knockBack = 6.5f;
        Item.mana = 5;
        Item.rare = ItemRarityID.White;
        Item.value = Item.sellPrice(silver: 10);
        Item.shoot = ModContent.ProjectileType<HallowedTridentProj>();
        Item.useAnimation = 31;
        Item.useTime = 31;

        // Texture settings
        Item.width = 44;
        Item.height = 44;
        Item.scale = 1f;

        // Default Stats
        Item.shootSpeed = 9f;
        Item.useStyle = ItemUseStyleID.Shoot;
        Item.DamageType = DamageClass.Magic;
        Item.noMelee = true;
        Item.noUseGraphic = true;
        Item.autoReuse = true;
        Item.UseSound = SoundID.Item71;
    }

    public override void AddRecipes()
    {
        //CreateRecipe()
        //    .AddIngredient<AuraliteOre>(10)
        //    .AddTile(TileID.Anvils)
        //    .Register();
    }

    public override bool CanUseItem(Player player)
    {
        return player.ownedProjectileCounts[Item.shoot] < 1;
    }
}
public class HallowedTridentProj : TridentBase
{
    protected override float HoldoutRangeMax => 120f;
    public override void SetDefaults()
    {

        Projectile.width = 15;
        Projectile.height = 15;
        Projectile.aiStyle = ProjAIStyleID.Spear;
        Projectile.penetrate = -1;
        Projectile.scale = 1.3f;
        Projectile.alpha = 0;
        Projectile.hide = true;
        Projectile.ownerHitCheck = true;
        Projectile.DamageType = DamageClass.Magic;
        Projectile.tileCollide = false;
        Projectile.friendly = true;
    }
}