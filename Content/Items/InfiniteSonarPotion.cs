using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteSonarPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.SonarPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Sonar };

		protected override void BuffEffect(Player player)
		{
			player.sonarPotion = true;
		}
	}
}
