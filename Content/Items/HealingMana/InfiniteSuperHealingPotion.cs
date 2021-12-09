using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.HealingMana
{
	public class InfiniteSuperHealingPotion : BaseRestoPotion
	{
		protected override int BaseItemType => ItemID.SuperHealingPotion;

		public override void AddRecipes()
		{
			base.AddRecipes();
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<InfiniteGreaterHealingPotion>(), 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 30);
			recipe.AddIngredient(ItemID.FragmentSolar, 30);
			recipe.AddIngredient(ItemID.FragmentStardust, 30);
			recipe.AddIngredient(ItemID.FragmentVortex, 30);
			recipe.Register();
		}
	}
}
