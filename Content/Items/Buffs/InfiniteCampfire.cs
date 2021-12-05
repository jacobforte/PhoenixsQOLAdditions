using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteCampfire : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteCampfire");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.Campfire] = true;
			Main.SceneMetrics.HasCampfire = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddRecipeGroup("PhoenixsQOLAdditions:Campfire", 10);
			recipe.Register();
		}
	}
}
