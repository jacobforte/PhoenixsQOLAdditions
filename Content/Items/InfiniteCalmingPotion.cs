using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteCalmingPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.CalmingPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Calm };

		protected override void BuffEffect(Player player)
		{
			if (PhoenixsQOLAdditions.PeaceEnabled)
			{
				player.calmed = true;
			}
		}
	}
}
