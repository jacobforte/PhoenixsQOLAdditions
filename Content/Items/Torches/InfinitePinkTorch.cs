using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfinitePinkTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Pink;

		protected override int TorchItemType => ItemID.PinkTorch;

		protected override int TorchDustType => DustID.PinkTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
