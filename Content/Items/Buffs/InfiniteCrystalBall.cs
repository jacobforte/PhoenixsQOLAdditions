using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteCrystalBall : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteCrystalBall");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.Clairvoyance] = true;
			player.GetCritChance(DamageClass.Magic) += 2;
			player.GetDamage(DamageClass.Magic) += 0.05f;
			player.statManaMax2 += 20;
			player.manaCost -= 0.02f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.CrystalBall, 5);
			recipe.Register();
		}
	}
}
