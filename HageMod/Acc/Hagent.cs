using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace HageMod.Acc
{
    public class Hagent : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Hagent. 50 Increased Max Mana 10% Increased Magic Damage");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = 100;
            item.rare = 8;
			item.accessory = true;
            // Set other item.X values here
			item.defense = 5;
        }
		
		public override void UpdateAccessory(Player player, bool hideVisual) {
			
		player.statManaMax2 += 50;
		player.magicDamage += 0.1f;
		}

        public override void AddRecipes()
        {
            // Recipes here. See Basic Recipe Guide
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sunglasses, 1);
			recipe.AddIngredient(ItemID.Ruby, 5);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
        }
	}
}		
