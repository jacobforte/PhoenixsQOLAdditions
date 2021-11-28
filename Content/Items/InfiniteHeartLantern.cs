using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteHeartLantern : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteHeartLantern");

		protected override int Value => 5000;

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.HeartLamp] = true;
			Main.SceneMetrics.HasHeartLantern = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HeartLantern, 10);
			recipe.Register();
		}
	}
}
