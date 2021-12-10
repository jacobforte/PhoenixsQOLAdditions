using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public class InfiniteSpikyBall : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.SpikyBall;

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.ConsumableThatDamages;
		}
	}
}
