using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Flasks
{
	public class InfiniteFlaskOfVenom : BaseInfiniteFlask
	{
		protected override int BaseItemType => ItemID.FlaskofVenom;

		protected override byte MeleeEnchant => 1;
	}
}
