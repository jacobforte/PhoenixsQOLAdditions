using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteWellFed : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.GoldenDelight;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.WellFed, BuffID.WellFed2, BuffID.WellFed3 };

		protected override int Value => 22000;

		protected override void BuffEffect(Player player)
		{
			player.statDefense += 4;
			player.GetCritChance(DamageClass.Generic) += 4;
			player.meleeSpeed += 0.1f;
			player.GetDamage(DamageClass.Generic) += 0.1f;
			player.maxMinions += 1;
			player.moveSpeed += 0.4f;
			player.pickSpeed += 0.15f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("PhoenixsQOLAdditions:WellFed", 30);
			recipe.AddRecipeGroup("PhoenixsQOLAdditions:PlentySatisfied", 30);
			recipe.AddRecipeGroup("PhoenixsQOLAdditions:ExquisitelyStuffed", 30);
			recipe.Register();
		}
	}
}
