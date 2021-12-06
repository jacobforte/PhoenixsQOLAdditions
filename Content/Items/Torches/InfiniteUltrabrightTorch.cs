using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteUltrabrightTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.UltraBright;

		protected override int TorchItemType => ItemID.UltrabrightTorch;

		protected override int TorchDustType => DustID.UltraBrightTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
