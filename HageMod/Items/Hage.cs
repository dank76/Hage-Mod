using Terraria.ID;
using Terraria.ModLoader;

namespace HageMod.Items
{
	public class Hage : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Hage"); 
			Tooltip.SetDefault("hage.");
		}

		public override void SetDefaults() 
		{
			item.damage = 323;
			item.magic = true;
			item.mana = 5;
			item.shoot = ModContent.ProjectileType<HageProj>();
			item.shootSpeed = 10f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item39;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}