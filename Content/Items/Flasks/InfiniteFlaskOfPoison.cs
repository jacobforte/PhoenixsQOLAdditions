using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Flasks
{
	public class InfiniteFlaskOfPoison : BaseInfiniteFlask
	{
		protected override int BaseItemType => ItemID.FlaskofPoison;

		protected override byte MeleeEnchant => 8;
	}
}
