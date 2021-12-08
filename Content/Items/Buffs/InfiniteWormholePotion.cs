using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteWormholePotion : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteWormholePotion");

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.WormholePotion, 30);
			recipe.Register();
		}
	}
}
