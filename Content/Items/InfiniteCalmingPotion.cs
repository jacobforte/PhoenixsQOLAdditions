using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteCalmingPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.CalmingPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Calm };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.calmed = true;
		}
	}
}
