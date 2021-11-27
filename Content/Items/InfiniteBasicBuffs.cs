using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteBasicBuffs : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault($"Test");
		}

		public override void SetDefaults()
		{
			Item.maxStack = 1;
			Item.value = 12000;
			Item.rare = 3;
		}

		public override void UpdateInventory(Player player)
		{
			base.UpdateInventory(player);

			if (!player.HasItem(ModContent.ItemType<InfiniteIronskinPotion>()))
			{
				player.statDefense += 8;
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<InfiniteIronskinPotion>(), 1);
			recipe.AddIngredient(ModContent.ItemType<InfiniteRegenerationPotion>(), 1);
			recipe.AddIngredient(ModContent.ItemType<InfiniteSwiftnessPotion>(), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
