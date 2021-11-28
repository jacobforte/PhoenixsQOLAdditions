﻿using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteStarInABottle : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteStarInABottle");

		protected override int Value => 100;

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
