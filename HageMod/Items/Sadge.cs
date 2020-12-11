using Terraria.ID;
using Terraria.ModLoader;

namespace HageMod.Items
{
	public class Sadge : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("Sadge"); 
			Tooltip.SetDefault("pure saddness.");
		}

		public override void SetDefaults() 
		{
			item.damage = 700;
			item.magic = true;
			item.mana = 200;
			item.shoot = ModContent.ProjectileType<SadgeProj>();
			item.shootSpeed = 10f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.useTime = 80;
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
			recipe.AddIngredient(ItemID.Ruby, 15);
			recipe.AddIngredient(ItemID.LunarBar, 15);
			recipe.AddIngredient(ItemID.FragmentNebula, 25);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}