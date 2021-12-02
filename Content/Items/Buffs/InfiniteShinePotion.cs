using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteShinePotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.ShinePotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Shine };

		protected override void BuffEffect(Player player)
		{
			Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0.8f, 0.95f, 1f);
		}
	}
}
