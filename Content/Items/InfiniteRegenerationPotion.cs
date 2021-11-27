using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteRegenerationPotion : Tier1Buff
	{
		public override int BaseItem => ItemID.RegenerationPotion;

		public override int BaseBuff => BuffID.Regeneration;

		public override int Value => 6000;

		public override void BuffEffect(Player player)
		{
			player.lifeRegen += 1;
		}
	}
}
