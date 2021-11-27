using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public abstract class Tier1Buff : ModItem
	{
		public abstract int BaseItem { get; }
		public abstract int BaseBuff { get; }
		public abstract int Value { get; }
		public abstract void BuffEffect(Player player);

		public override void SetStaticDefaults()
		{
			var tooltip = Lang.GetTooltip(BaseItem);
			List<string> lines = new List<string>();
			for (int i = 0; i < tooltip.Lines; i++)
			{
				lines.Add(tooltip.GetLine(i));
			}

			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "Tier1Buff", string.Join('\n', lines)));
		}

		public sealed override void SetDefaults()
		{
			Item.maxStack = 1;
			Item.value = Value;
			Item.rare = 2;
		}

		public sealed override void UpdateInventory(Player player)
		{
			base.UpdateInventory(player);
			if (!player.HasBuff(BaseBuff))
			{
				BuffEffect(player);
			}
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(BaseItem, 30);
			recipe.Register();
		}
	}
}
