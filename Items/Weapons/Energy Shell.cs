using railgunMod;
using Terraria;
using Terraria.ID;
using railgunMod.Projectiles;
using Terraria.ModLoader;

namespace railgunMod.Items.Weapons
{
    public class EnergyShell : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Used with Railguns. Pure mana compacted into a battery.");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.magic = true;
            item.width = 14;
            item.height = 14;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1f;
            item.value = Item.sellPrice(0, 2, 14, 0);
            item.rare = ItemRarityID.Yellow;
            item.shoot = ModContent.ProjectileType<Laser>();
            item.ammo = item.useAmmo = ModContent.ItemType<EnergyShell>();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 25);
            recipe.AddIngredient(ItemID.Ruby, 10);
            recipe.AddIngredient(ItemID.Wire, 20);
            recipe.AddIngredient(ItemID.SoulofFright, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ModContent.ItemType<EnergyShell>(), 50);
            recipe.AddRecipe();
        }
    }
}