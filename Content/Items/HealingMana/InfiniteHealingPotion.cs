using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.HealingMana
{
	public class InfiniteHealingPotion : BaseRestoPotion
	{
		protected override int BaseItemType => ItemID.HealingPotion;

		public override void AddRecipes()
		{
			base.AddRecipes();
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<InfiniteLesserHealingPotion>(), 2);
			recipe.AddIngredient(ItemID.GlowingMushroom, 30);
			recipe.Register();
		}
	}
}
