﻿using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	public class InfiniteWetBomb : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.WetBomb;

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.Bombs;
		}
	}
}
