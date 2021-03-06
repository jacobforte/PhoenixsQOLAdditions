using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteHeartLantern : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteHeartLantern");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.HeartLamp] = true;
			Main.SceneMetrics.HasHeartLantern = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.HeartLantern, 10);
			recipe.Register();
		}
	}
}
