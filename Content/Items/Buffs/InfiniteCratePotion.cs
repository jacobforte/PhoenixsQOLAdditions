using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteCratePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.CratePotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Crate };

		protected override void BuffEffect(Player player)
		{
			if (ModContent.GetInstance<PhoenixsModConfig>().CrateBuffEnabled)
			{
				player.cratePotion = true;
			}
		}
	}
}
