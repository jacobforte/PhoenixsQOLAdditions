using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Torch;

		protected override int TorchItemType => ItemID.Torch;

		protected override int TorchDustType => DustID.Torch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
