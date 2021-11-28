using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteBattlePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.BattlePotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Battle };

		protected override int Value => 5000;

		protected override void BuffEffect(Player player)
		{
			player.enemySpawns = true;
		}
	}
}
