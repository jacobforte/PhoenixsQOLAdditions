using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteWrathPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.WrathPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Wrath };

		protected override void BuffEffect(Player player)
		{
			player.GetDamage(DamageClass.Generic) += 0.1f;
		}
	}
}
