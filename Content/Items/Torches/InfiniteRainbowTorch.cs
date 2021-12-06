using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteRainbowTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Rainbow;

		protected override int TorchItemType => ItemID.RainbowTorch;

		protected override int TorchDustType => DustID.RainbowTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
