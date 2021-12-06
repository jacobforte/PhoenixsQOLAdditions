using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteIceTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Ice;

		protected override int TorchItemType => ItemID.IceTorch;

		protected override int TorchDustType => DustID.IceTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
