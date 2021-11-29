using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;

namespace PhoenixsQOLAdditions.Content.Items
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
			if (player.whoAmI != Main.myPlayer || !player.hostile)
				return;

			int num2 = 24;
			float num3 = 200f;
			bool flag = player.infernoCounter % 60 == 0;
			int damage = 10;

			for (int k = 0; k < 200; k++)
			{
				NPC nPC = Main.npc[k];
				if (nPC.active && !nPC.friendly && nPC.damage > 0 && !nPC.dontTakeDamage && !nPC.buffImmune[num2] && player.CanNPCBeHitByPlayerOrPlayerProjectile(nPC) && Vector2.Distance(player.Center, nPC.Center) <= num3)
				{
					if (nPC.FindBuffIndex(num2) == -1)
						nPC.AddBuff(num2, 120);

					if (flag)
						player.ApplyDamageToNPC(nPC, damage, 0f, 0, crit: false);
				}
			}
		}
	}
}
