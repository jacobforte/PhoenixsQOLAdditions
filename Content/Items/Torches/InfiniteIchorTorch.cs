using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteIchorTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Ichor;

		protected override int TorchItemType => ItemID.IchorTorch;

		protected override int TorchDustType => DustID.IchorTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
			wetTorch = true;
		}
	}
}
