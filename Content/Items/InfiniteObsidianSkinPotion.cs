using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteObsidianSkinPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.ObsidianSkinPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.ObsidianSkin };

		protected override void BuffEffect(Player player)
		{
			player.lavaImmune = true;
			player.fireWalk = true;
			player.buffImmune[24] = true;
		}
	}
}
