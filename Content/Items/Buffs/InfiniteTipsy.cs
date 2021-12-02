using PhoenixsQOLAdditions.Common.Configs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteTipsy : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteTipsy");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.Tipsy] = true;
			if (ModContent.GetInstance<PhoenixsModConfig>().TipsyReducesDefense && new Item(player.selectedItem).DamageType == DamageClass.Melee)
			{
				player.statDefense -= 4;
			}
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
