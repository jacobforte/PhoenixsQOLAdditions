using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public class InfiniteMolotovCocktail : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.MolotovCocktail;

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.ConsumableThatDamages;
		}
	}
}
