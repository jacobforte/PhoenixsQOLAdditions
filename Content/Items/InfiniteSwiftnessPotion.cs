using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteSwiftnessPotion : Tier1Buff
	{
		public override int BaseItem => ItemID.SwiftnessPotion;

		public override int BaseBuff => BuffID.Swiftness;

		public override int Value => 6000;

		public override void BuffEffect(Player player)
		{
			player.moveSpeed *= (float)1.25;
		}
	}
}
