using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteDemonTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Demon;

		protected override int TorchItemType => ItemID.DemonTorch;

		protected override int TorchDustType => DustID.DemonTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
