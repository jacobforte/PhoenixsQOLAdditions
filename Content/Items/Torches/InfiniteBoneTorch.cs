using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Torches
{
	public class InfiniteBoneTorch : BaseInfiniteTorch
	{
		protected override int TorchType => TorchID.Bone;

		protected override int TorchItemType => ItemID.BoneTorch;

		protected override int TorchDustType => DustID.BoneTorch;

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}
	}
}
