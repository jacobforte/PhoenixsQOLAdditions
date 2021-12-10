using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteStarInABottle : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;
		protected sealed override string DisplayNameString => PhoenixsQOLAdditions.GetText("DisplayName", "Infinite", Lang.GetItemName(ItemID.StarinaBottle));
		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteStarInABottle");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.StarInBottle] = true;
			player.manaRegenBonus += 2;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.StarinaBottle, 10);
			recipe.Register();
		}
	}
}
