using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfinitePeaceCandle : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfinitePeaceCandle");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.PeaceCandle] = true;
			if (ModContent.GetInstance<PhoenixsModConfig>().PeaceEnabled)
			{
				player.ZonePeaceCandle = true;
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.PeaceCandle, 10);
			recipe.Register();
		}
	}
}
