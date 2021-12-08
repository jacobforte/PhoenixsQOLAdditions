using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteManaRegenerationPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.ManaRegenerationPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.ManaRegeneration };

		protected override void BuffEffect(Player player)
		{
			player.manaRegenBuff = true;
		}
	}
}
