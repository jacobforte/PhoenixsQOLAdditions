using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteAmmoBox : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteAmmoBox");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.AmmoBox] = true;
			player.ammoBox = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.AmmoBox, 5);
			recipe.Register();
		}
	}
}
