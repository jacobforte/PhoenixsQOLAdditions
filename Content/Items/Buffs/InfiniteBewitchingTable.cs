using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteBewitchingTable : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteBewitchingTable");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.Bewitched] = true;
			player.maxMinions += 1;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.BewitchingTable, 5);
			recipe.Register();
		}
	}
}
