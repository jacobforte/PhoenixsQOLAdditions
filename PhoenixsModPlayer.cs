using Microsoft.Xna.Framework;
using PhoenixsQOLAdditions.Content.Items.Buffs;
using Terraria;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;

namespace PhoenixsQOLAdditions
{
	public class PhoenixsModPlayer : ModPlayer
	{
		private Vector2? ReturnLocation;

		public override void ProcessTriggers(TriggersSet triggersSet)
		{
			if (PhoenixsQOLAdditions.QuickRecallKeybind.JustPressed && (Player.HasItem(ModContent.ItemType<InfiniteRecallPotion>()) || Player.HasItem(ModContent.ItemType<InfiniteReturnPotion>()) || Player.HasItem(ModContent.ItemType<InfiniteTravelBuffs>()) || Player.HasItem(ModContent.ItemType<InfiniteBuffs>())))
			{
				ReturnLocation = Player.position;
				SoundEngine.PlaySound(SoundID.Item6, Player.position);
				for (int num4 = 0; num4 < 70; num4++)
				{
					Main.dust[Dust.NewDust(Player.position, Player.width, Player.height, DustID.MagicMirror, Player.velocity.X * 0.2f, Player.velocity.Y * 0.2f, 150, Color.Cyan, 1.2f)].velocity *= 0.5f;
				}

				Player.RemoveAllGrapplingHooks();
				bool flag5 = Player.immune;
				int num5 = Player.immuneTime;
				Player.Spawn(PlayerSpawnContext.RecallFromItem);
				Player.immune = flag5;
				Player.immuneTime = num5;
				for (int num6 = 0; num6 < 70; num6++)
				{
					Main.dust[Dust.NewDust(Player.position, Player.width, Player.height, DustID.MagicMirror, 0f, 0f, 150, Color.Cyan, 1.2f)].velocity *= 0.5f;
				}
			}
			else if (PhoenixsQOLAdditions.QuickReturnKeybind.JustPressed && ReturnLocation != null && (Player.HasItem(ModContent.ItemType<InfiniteReturnPotion>()) || Player.HasItem(ModContent.ItemType<InfiniteReturnPotion>()) || Player.HasItem(ModContent.ItemType<InfiniteBuffs>())))
			{
				SoundEngine.PlaySound(SoundID.Item6, Player.position);
				for (int num4 = 0; num4 < 70; num4++)
				{
					Main.dust[Dust.NewDust(Player.position, Player.width, Player.height, DustID.MagicMirror, Player.velocity.X * 0.2f, Player.velocity.Y * 0.2f, 150, Color.Cyan, 1.2f)].velocity *= 0.5f;
				}

				Player.RemoveAllGrapplingHooks();
				bool flag5 = Player.immune;
				int num5 = Player.immuneTime;
				Player.Teleport(ReturnLocation.Value);
				Player.immune = flag5;
				Player.immuneTime = num5;
				for (int num6 = 0; num6 < 70; num6++)
				{
					Main.dust[Dust.NewDust(Player.position, Player.width, Player.height, DustID.MagicMirror, 0f, 0f, 150, Color.Cyan, 1.2f)].velocity *= 0.5f;
				}
				ReturnLocation = null;
			}
			else if (PhoenixsQOLAdditions.ToggleMenuKeybind.JustPressed)
			{
				PhoenixsQOLAdditions.ShowToggleMenu = !PhoenixsQOLAdditions.ShowToggleMenu;
			}
		}
	}
}
