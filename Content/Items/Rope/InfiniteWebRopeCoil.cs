using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Rope
{
	public class InfiniteWebRopeCoil : BaseInfiniteRope
	{
		protected override int BaseItemType => ItemID.WebRopeCoil;

		public override void AddRecipes()
		{
			base.AddRecipes();
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<InfiniteWebRope>(1);
			recipe.Register();
		}
	}
}
