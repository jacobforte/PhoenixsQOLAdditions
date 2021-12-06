using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteHallowedTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Hallowed;

		protected override int TorchItemType => ItemID.HallowedTorch;

		protected override int TorchDustType => DustID.HallowedTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
