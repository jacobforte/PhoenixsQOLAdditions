using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteSunflower : BaseInfiniteBuffs
	{
		protected override int Rarity => ItemRarityID.Green;

		protected override string TooltipString => PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteSunflower");

		public sealed override void UpdateInventory(Player player)
		{
			player.buffImmune[BuffID.Sunflower] = true;
			player.moveSpeed += 0.1f;
			player.moveSpeed *= 1.1f;
			if (ModContent.GetInstance<PhoenixsModConfig>().PeaceEnabled)
			{
				player.sunflower = true;
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Sunflower, 99);
			recipe.Register();
		}
	}
}
