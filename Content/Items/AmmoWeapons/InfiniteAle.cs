using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.AmmoWeapons
{
	// TODO Remove tooltip
	public class InfiniteAle : BaseInfiniteAmmo
	{
		protected override int BaseItemType => ItemID.Ale;

		public override void SetDefaults()
		{
			base.SetDefaults();
			Item.holdStyle = 0;
			Item.useStyle = 0;
		}
	}
}
