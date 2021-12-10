using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public class InfiniteFrostDaggerfish : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.FrostDaggerfish;

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.ConsumableThatDamages;
		}
	}
}
