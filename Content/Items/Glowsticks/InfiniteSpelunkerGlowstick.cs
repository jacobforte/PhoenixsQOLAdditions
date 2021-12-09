using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Glowsticks
{
	public class InfiniteSpelunkerGlowstick : BaseInfiniteGlowstick
	{
		protected override Vector3 GlowstickColorRGB => new Vector3(1.05f, 0.95f, 0.55f);

		protected override int GlowstickItemType => ItemID.SpelunkerGlowstick;

		public override void HoldItem(Player player)
		{
			base.HoldItem(player);

			player.spelunkerTimer++;
			if (player.spelunkerTimer >= 10)
			{
				player.spelunkerTimer = 0;
				Main.instance.SpelunkerProjectileHelper.AddSpotToCheck(player.Center);
			}
		}

		public override void PostUpdate()
		{
			base.PostUpdate();

			var player = Main.LocalPlayer;
			player.spelunkerTimer++;
			if (player.spelunkerTimer >= 10)
			{
				player.spelunkerTimer = 0;
				Main.instance.SpelunkerProjectileHelper.AddSpotToCheck(player.Center);
			}
		}
	}
}
