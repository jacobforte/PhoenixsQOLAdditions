using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public abstract class BaseInfiniteTorch : ModItem
	{
		protected abstract int TorchType { get; }
		protected abstract int TorchItemType { get; }
		protected abstract int TorchDustType { get; }

		public sealed override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			var baseTooltip = Lang.GetTooltip(TorchItemType);
			string baseTooltipString = "";
			if (baseTooltip.Lines > 0)
			{
				baseTooltipString = baseTooltip?.GetLine(0);
			}
			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteTorch", baseTooltipString));
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(TorchItemType);
			Item.maxStack = 1;
			Item.consumable = false;
			Item.value = 0;
			Item.rare = ItemRarityID.Green;
		}

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.Torches;
		}

		public override void HoldItem(Player player)
		{
			if (Main.rand.Next(player.itemAnimation > 0 ? 40 : 80) == 0 && TorchDustType != -1)
			{
				Dust.CloneDust(TorchDustType);
			}

			// Createlight at the torch's approximate position, when the item is held.
			Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);

			Lighting.AddLight(position, TorchType);
		}

		public override void PostUpdate()
		{
			if (!Item.noWet || !Item.wet)
			{
				Lighting.AddLight(Item.Center, TorchType);
			}
		}

		public sealed override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(TorchItemType, 3996);
			recipe.Register();
		}
	}
}
