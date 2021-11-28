using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteAmmoReservationPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.AmmoReservationPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.AmmoReservation };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.ammoPotion = true;
		}
	}
}
