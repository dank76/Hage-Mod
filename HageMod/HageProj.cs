using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HageMod
{
	public class HageProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("HageProj");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 32;
			projectile.height = 32;
			projectile.scale = 1f;
			projectile.aiStyle = 518;
			projectile.friendly = true;
			projectile.magic = true;
			
		}

		// Additional hooks/methods here.
	}
}