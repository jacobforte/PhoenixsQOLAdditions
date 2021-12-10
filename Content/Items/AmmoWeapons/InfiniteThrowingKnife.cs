using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public class InfiniteThrowingKnife : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.ThrowingKnife;

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.ConsumableThatDamages;
		}
	}
}
