using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteCrimsonTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Crimson;

		protected override int TorchItemType => ItemID.CrimsonTorch;

		protected override int TorchDustType => DustID.CrimsonTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
