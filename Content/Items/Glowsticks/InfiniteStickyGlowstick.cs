using Microsoft.Xna.Framework;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Glowsticks
{
	public class InfiniteStickyGlowstick : BaseInfiniteGlowstick
	{
		protected override Vector3 GlowstickColorRGB => new Vector3(0.7f, 0.8f, 1f);

		protected override int GlowstickItemType => ItemID.StickyGlowstick;
	}
}
