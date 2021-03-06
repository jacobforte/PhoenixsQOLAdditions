using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteCake : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteCake");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.SugarRush] = true;
			player.pickSpeed -= 0.2f;
			player.moveSpeed += 0.2f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SliceOfCake, 5);
			recipe.Register();
		}
	}
}
