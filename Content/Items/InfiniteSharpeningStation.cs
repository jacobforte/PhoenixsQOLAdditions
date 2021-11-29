using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteSharpeningStation : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteSharpeningStation");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.Sharpened] = true;
			if (player.inventory[player.selectedItem].DamageType == DamageClass.Melee)
			{
				player.armorPenetration = 12;
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SharpeningStation, 5);
			recipe.Register();
		}
	}
}
