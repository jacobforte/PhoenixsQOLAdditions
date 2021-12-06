using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteOrangeTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Orange;

		protected override int TorchItemType => ItemID.OrangeTorch;

		protected override int TorchDustType => DustID.OrangeTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
