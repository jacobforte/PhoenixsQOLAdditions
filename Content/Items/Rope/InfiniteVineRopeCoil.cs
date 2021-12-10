using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Rope
{
	public class InfiniteVineRopeCoil : BaseInfiniteRope
	{
		protected override int BaseItemType => ItemID.VineRopeCoil;

		public override void AddRecipes()
		{
			base.AddRecipes();
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<InfiniteVineRope>(1);
			recipe.Register();
		}
	}
}
