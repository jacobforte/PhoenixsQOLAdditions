using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Rope
{
	public class InfiniteRopeCoil : BaseInfiniteRope
	{
		protected override int BaseItemType => ItemID.RopeCoil;

		public override void AddRecipes()
		{
			base.AddRecipes();
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<InfiniteRope>(1);
			recipe.Register();
		}
	}
}
