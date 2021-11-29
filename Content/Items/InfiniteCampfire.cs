using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteCampfire : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteCampfire");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.Campfire] = true;
			Main.SceneMetrics.HasCampfire = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("PhoenixsQOLAdditions:Campfire", 10);
			recipe.Register();
		}
	}
}
