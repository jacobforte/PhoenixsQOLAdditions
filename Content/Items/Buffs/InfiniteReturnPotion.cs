using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteReturnPotion : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteReturnPotion");

		public override void AddRecipes()
		{
			Recipe recipe1 = CreateRecipe();
			recipe1.AddIngredient(ItemID.PotionOfReturn, 30);
			recipe1.Register();
			Recipe recipe2 = CreateRecipe();
			recipe2.AddIngredient(ItemID.Obsidifish, 30);
			recipe2.AddIngredient(ModContent.ItemType<InfiniteRecallPotion>(), 1);
			recipe2.Register();
		}
	}
}
