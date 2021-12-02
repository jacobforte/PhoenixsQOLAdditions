using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items.Buffs
{
	public class InfiniteInfernoPotion : Tier1InfiniteBuff
	{
		protected override int BaseItem => ItemID.InfernoPotion;

		protected override List<int> IncompatibleBuffs => new List<int> { BuffID.Inferno };

		protected override void BuffEffect(Player player)
		{
			player.inferno = true;
			if (PhoenixsQOLAdditions.InfernoVisualEnabled)
			{
				Lighting.AddLight((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f), 0.65f, 0.4f, 0.1f);
			}
			if (player.whoAmI != Main.myPlayer)
				return;

			int num2 = 24;
			float num3 = 200f;
			bool flag = player.infernoCounter % 60 == 0;
			int damage = 10;

			for (int k = 0; k < 200; k++)
			{
				NPC nPC = Main.npc[k];
				if (nPC.active && !nPC.friendly && nPC.damage > 0 && !nPC.dontTakeDamage && !nPC.buffImmune[num2] && player.CanNPCBeHitByPlayerOrPlayerProjectile(nPC) && Vector2.Distance(player.Center, nPC.Center) <= num3) {
					if (nPC.FindBuffIndex(num2) == -1)
						nPC.AddBuff(num2, 120);

					if (flag)
						player.ApplyDamageToNPC(nPC, damage, 0f, 0, crit: false);
				}
			}

			if (!player.hostile)
				return;

			for (int l = 0; l < 255; l++)
			{
				Player _player = Main.player[l];
				if (_player == player || !_player.active || _player.dead || !_player.hostile || _player.buffImmune[num2] || (_player.team == player.team && _player.team != 0) || !(Vector2.Distance(player.Center, _player.Center) <= num3))
					continue;

				if (_player.FindBuffIndex(num2) == -1)
					_player.AddBuff(num2, 120);

				if (flag)
				{
					_player.Hurt(PlayerDeathReason.LegacyEmpty(), damage, 0, pvp: true);
					if (Main.netMode != 0)
					{
						PlayerDeathReason reason = PlayerDeathReason.ByOther(16);
						NetMessage.SendPlayerHurt(l, reason, damage, 0, critical: false, pvp: true, -1);
					}
				}
			}
		}
	}
}
