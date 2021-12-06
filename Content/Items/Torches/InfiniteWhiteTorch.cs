using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteWhiteTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.White;

		protected override int TorchItemType => ItemID.WhiteTorch;

		protected override int TorchDustType => DustID.WhiteTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
