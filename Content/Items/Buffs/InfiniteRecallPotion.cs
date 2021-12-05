using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteRecallPotion : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteRecallPotion");

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.RecallPotion, 30);
			recipe.Register();
		}
	}
}
