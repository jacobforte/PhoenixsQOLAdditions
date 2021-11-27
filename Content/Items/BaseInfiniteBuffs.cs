using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Runtime.Versioning;

namespace PhoenixsQOLAdditions.Content.Items
{
	public abstract class BaseInfiniteBuffs : ModItem
	{
		protected abstract int Rarity { get; }
		protected abstract string TooltipString { get; }
		protected abstract int Value { get; }

		public sealed override void SetStaticDefaults()
		{
			Tooltip.SetDefault(TooltipString);
		}

		public sealed override void SetDefaults()
		{
			Item.maxStack = 1;
			Item.value = Value;
			Item.rare = Rarity;
		}
	}
}
