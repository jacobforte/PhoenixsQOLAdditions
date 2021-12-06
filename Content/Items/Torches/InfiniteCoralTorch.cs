using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteCoralTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Coral;

		protected override int TorchItemType => ItemID.CoralTorch;

		protected override int TorchDustType => DustID.CoralTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			wetTorch = true;
		}
	}
}
