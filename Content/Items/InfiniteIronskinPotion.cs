using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions.Content.Items
{
	public class InfiniteIronskinPotion : Tier1Buff
	{
		public override int BaseItem => ItemID.IronskinPotion;

		public override int BaseBuff => BuffID.Ironskin;

		public override int Value => 6000;

		public override void BuffEffect(Player player)
		{
			player.statDefense += 8;
		}
	}
}
