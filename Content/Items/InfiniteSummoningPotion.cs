﻿using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteSummoningPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.SummoningPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Summoning };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.maxMinions += 1;
		}
	}
}