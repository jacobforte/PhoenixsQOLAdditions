using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfinitePurpleTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Purple;

		protected override int TorchItemType => ItemID.PurpleTorch;

		protected override int TorchDustType => DustID.PurpleTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
