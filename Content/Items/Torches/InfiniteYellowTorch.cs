using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteYellowTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Yellow;

		protected override int TorchItemType => ItemID.YellowTorch;

		protected override int TorchDustType => DustID.YellowTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
