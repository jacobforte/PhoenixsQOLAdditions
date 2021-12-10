using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Rope
{
	public class InfiniteWebRope : BaseInfiniteRope
	{
		protected override int BaseItemType => ItemID.WebRope;

		public override void AddRecipes()
		{
			base.AddRecipes();
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<InfiniteWebRopeCoil>(1);
			recipe.Register();
		}
	}
}
