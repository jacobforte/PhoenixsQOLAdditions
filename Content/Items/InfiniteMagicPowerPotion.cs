﻿using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteMagicPowerPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.MagicPowerPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.MagicPower };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.GetDamage(DamageClass.Magic) += 0.2f;
		}
	}
}
