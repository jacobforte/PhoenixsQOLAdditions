using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteBattlePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.BattlePotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Battle };

		protected override void BuffEffect(Player player)
		{
			if (ModContent.GetInstance<PhoenixsModConfig>().BattlerEnabled)
			{
				player.enemySpawns = true;
			}
		}
	}
}
