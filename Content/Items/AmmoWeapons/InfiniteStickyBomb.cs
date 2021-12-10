using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public class InfiniteStickyBomb : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.StickyBomb;

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.Bombs;
		}
	}
}
