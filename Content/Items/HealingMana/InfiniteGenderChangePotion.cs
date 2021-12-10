using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.HealingMana
{
	public class InfiniteGenderChangePotion : BaseRestoPotion
	{
		protected override int BaseItemType => ItemID.GenderChangePotion;

		public override bool? UseItem(Player player)
		{
			player.Male = !player.Male;
			return true;
		}
	}
}
