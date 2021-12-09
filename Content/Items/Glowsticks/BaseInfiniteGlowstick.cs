using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Glowsticks
{
	//TODO: fix the slight offset the infinite glowsticks have. Are infinite glowsticks slightly brighter? Might need to fix that as well.
	public abstract class BaseInfiniteGlowstick : ModItem
	{
		protected abstract Vector3 GlowstickColorRGB { get; } 
		protected abstract int GlowstickItemType { get; }
		
		public sealed override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
			var baseTooltip = Lang.GetTooltip(GlowstickItemType);
			string baseTooltipString = "";
			if (baseTooltip.Lines > 0)
			{
				baseTooltipString = baseTooltip?.GetLine(0);
			}
			Tooltip.SetDefault(PhoenixsQOLAdditions.GetText("ItemTooltip", "InfiniteConsumable", baseTooltipString));
		}

		public override void SetDefaults()
		{
			Item.CloneDefaults(GlowstickItemType);
			Item.maxStack = 1;
			Item.consumable = false;
			Item.value = 0;
			Item.rare = ItemRarityID.Green;
		}

		public sealed override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			glowstick = true;
		}

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.Glowsticks;
		}

		public override void HoldItem(Player player)
		{
			Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);

			Lighting.AddLight(position, GlowstickColorRGB);
		}

		public override void PostUpdate()
		{
			if (!Item.noWet || !Item.wet)
			{
				Lighting.AddLight(Item.Center, GlowstickColorRGB);
			}
		}

		public sealed override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(GlowstickItemType, 3996);
			recipe.Register();
		}
	}
}
