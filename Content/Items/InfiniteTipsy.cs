using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteTipsy : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteTipsy");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.Tipsy] = true;
			player.GetCritChance(DamageClass.Melee) += 2;
			player.GetDamage(DamageClass.Melee) += 0.1f;
			player.meleeSpeed += 0.1f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("PhoenixsQOLAdditions:Tipsy", 30);
			recipe.Register();
		}
	}
}
