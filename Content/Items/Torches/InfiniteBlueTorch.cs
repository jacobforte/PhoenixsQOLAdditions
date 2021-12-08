using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteBlueTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Blue;

		protected override int TorchItemType => ItemID.BlueTorch;

		protected override int TorchDustType => DustID.BlueTorch;
		
		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
