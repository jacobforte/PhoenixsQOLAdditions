using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteExquisitelyStuffed : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.GoldenDelight;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.WellFed, BuffID.WellFed2, BuffID.WellFed3 };

		protected override void BuffEffect(Player player)
		{
			player.wellFed = true;
			player.statDefense += 4;
			player.GetCritChance(DamageClass.Melee) += 4;
			player.GetCritChance(DamageClass.Ranged) += 4;
			player.GetCritChance(DamageClass.Magic) += 4;
			player.GetDamage(DamageClass.Generic) += 0.1f;
			player.meleeSpeed += 0.1f;
			player.minionKB += 1f;
			player.moveSpeed += 0.4f;
			player.pickSpeed -= 0.15f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("PhoenixsQOLAdditions:ExquisitelyStuffed", 30);
			recipe.Register();
		}
	}
}
