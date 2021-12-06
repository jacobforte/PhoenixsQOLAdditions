using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteCorruptTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Corrupt;

		protected override int TorchItemType => ItemID.CorruptTorch;

		protected override int TorchDustType => DustID.CorruptTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
