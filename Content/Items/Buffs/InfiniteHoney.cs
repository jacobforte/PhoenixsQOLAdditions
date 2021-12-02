using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteHoney : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteHoney");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.Honey] = true;
			player.honey = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HoneyBucket, 30);
			recipe.Register();
		}
	}
}
