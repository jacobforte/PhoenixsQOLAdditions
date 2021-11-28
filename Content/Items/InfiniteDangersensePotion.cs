using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteDangersensePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.TrapsightPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Dangersense };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.dangerSense = true;
		}
	}
}
