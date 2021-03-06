using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public class InfiniteBomb : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.Bomb;

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.Bombs;
		}
	}
}
