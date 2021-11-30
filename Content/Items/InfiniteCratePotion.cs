using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteCratePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.CratePotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Crate };

		protected override void BuffEffect(Player player)
		{
			player.cratePotion = PhoenixsQOLAdditions.CrateBuffEnabled;
		}
	}
}
