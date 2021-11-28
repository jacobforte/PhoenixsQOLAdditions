using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	// Can't use Tier1 Buff class because we needed a custom tooltip string.
	public class InfiniteTipsy : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteTipsy");

		protected override int Value => 600;

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
