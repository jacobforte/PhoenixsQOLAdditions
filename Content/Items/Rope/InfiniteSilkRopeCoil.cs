using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Rope
{
	public class InfiniteSilkRopeCoil : BaseInfiniteRope
	{
		protected override int BaseItemType => ItemID.SilkRopeCoil;

		public override void AddRecipes()
		{
			base.AddRecipes();
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient<InfiniteSilkRope>(1);
			recipe.Register();
		}
	}
}
