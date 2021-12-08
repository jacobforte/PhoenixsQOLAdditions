using Microsoft.Xna.Framework;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Glowsticks
{
	public class InfiniteFairyGlowstick : BaseInfiniteGlowstick
	{
		protected override Vector3 GlowstickColorRGB => new Vector3(0.7f, 0f, 1f);

		protected override int GlowstickItemType => ItemID.FairyGlowstick;
	}
}
