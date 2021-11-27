﻿using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteRegenerationPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.RegenerationPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Regeneration };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.lifeRegen += 1;
		}
	}
}
