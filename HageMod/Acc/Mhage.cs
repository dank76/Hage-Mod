using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace HageMod.Acc
{
    public class Mhage : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Mhage best class. +100 Max Mana");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 11;
			item.accessory = true;
            // Set other item.X values here
			item.defense = 5;
        }
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			
		player.statManaMax2 += 100;
		player.magicDamage += 0.2f;
		}

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WizardHat, 1);
			recipe.AddIngredient(ItemID.Ruby, 5);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
        }
	}
}		
