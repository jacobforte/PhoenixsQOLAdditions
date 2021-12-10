using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public class InfiniteStickyDynamite : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.StickyDynamite;

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.Bombs;
		}
	}
}
