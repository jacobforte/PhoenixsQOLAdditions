using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteRagePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.RagePotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Rage };

		protected override void BuffEffect(Player player)
		{
			player.GetCritChance(DamageClass.Melee) += 10;
			player.GetCritChance(DamageClass.Ranged) += 10;
			player.GetCritChance(DamageClass.Magic) += 10;
		}
	}
}
