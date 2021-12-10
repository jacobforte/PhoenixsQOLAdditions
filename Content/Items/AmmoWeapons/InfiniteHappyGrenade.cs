using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public class InfiniteHappyGrenade : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.PartyGirlGrenade;

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.ConsumableThatDamages;
		}
	}
}
