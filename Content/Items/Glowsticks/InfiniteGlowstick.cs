using Microsoft.Xna.Framework;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Glowsticks
{
	public class InfiniteGlowstick : BaseInfiniteGlowstick
	{
		protected override Vector3 GlowstickColorRGB => new Vector3(0.7f, 1f, 0.8f);

		protected override int GlowstickItemType => ItemID.Glowstick;
	}
}
