using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Rope
{
	public class InfiniteVineRope : BaseInfiniteRope
	{
		protected override int BaseItemType => ItemID.VineRope;

		public override void AddRecipes()
		{
			base.AddRecipes();
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<InfiniteVineRopeCoil>(1);
			recipe.Register();
		}
	}
}
