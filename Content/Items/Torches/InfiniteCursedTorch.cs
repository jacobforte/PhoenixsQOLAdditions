using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteCursedTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Cursed;

		protected override int TorchItemType => ItemID.CursedTorch;

		protected override int TorchDustType => DustID.CursedTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
			wetTorch = true;
		}
	}
}
