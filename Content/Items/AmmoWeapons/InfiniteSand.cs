using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public class InfiniteSand : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.SandBlock;

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup(RecipeGroupID.Sand, 3996);
			recipe.Register();
		}
	}
}
