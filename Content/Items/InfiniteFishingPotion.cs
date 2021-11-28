using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteFishingPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.FishingPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Fishing };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.fishingSkill += 15;
		}
	}
}
