using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteRedTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Red;

		protected override int TorchItemType => ItemID.RedTorch;

		protected override int TorchDustType => DustID.RedTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
