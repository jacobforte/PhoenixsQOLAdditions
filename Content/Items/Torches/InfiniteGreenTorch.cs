using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteGreenTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Green;

		protected override int TorchItemType => ItemID.GreenTorch;

		protected override int TorchDustType => DustID.GreenTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
