using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Rope
{
	public class InfiniteSilkRope : BaseInfiniteRope
	{
		protected override int BaseItemType => ItemID.SilkRope;

		public override void AddRecipes()
		{
			base.AddRecipes();
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<InfiniteSilkRopeCoil>(1);
			recipe.Register();
		}
	}
}
