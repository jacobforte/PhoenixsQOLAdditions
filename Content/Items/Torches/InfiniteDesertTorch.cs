using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteDesertTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Desert;

		protected override int TorchItemType => ItemID.DesertTorch;

		protected override int TorchDustType => DustID.DesertTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
