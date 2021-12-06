using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteJungleTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Jungle;

		protected override int TorchItemType => ItemID.JungleTorch;

		protected override int TorchDustType => DustID.JungleTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
