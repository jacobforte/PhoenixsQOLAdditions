using Microsoft.Xna.Framework;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Glowsticks
{
	public class InfiniteBouncyGlowstick : BaseInfiniteGlowstick
	{
		protected override Vector3 GlowstickColorRGB => new Vector3(1f, 0.6f, 0.85f);

		protected override int GlowstickItemType => ItemID.BouncyGlowstick;
	}
}
