using Microsoft.Xna.Framework;
using PhoenixsQOLAdditions.UIElements;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;

namespace PhoenixsQOLAdditions
{
	public class PhoenixsModSystem : ModSystem
	{
		public override void UpdateUI(GameTime gameTime)
		{
			if (!Main.gameMenu && PhoenixsQOLAdditions.ShowToggleMenu)
			{
				if (Main.netMode == NetmodeID.SinglePlayer && (Main.playerInventory || Main.npcChatText != "" || Main.player[Main.myPlayer].sign >= 0 || Main.ingameOptionsWindow || Main.inFancyUI) && Main.autoPause)
					Main.LocalPlayer.GetModPlayer<PhoenixsModPlayer>().ProcessTriggers(null);
				PhoenixsQOLAdditions.ToggleMenuInterface?.Update(gameTime);
			}
		}

		public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
		{
			if (!Main.gameMenu && PhoenixsQOLAdditions.ShowToggleMenu)
			{
				int inventoryLayerIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
				if (inventoryLayerIndex != -1)
				{
					layers.Insert(inventoryLayerIndex, new LegacyGameInterfaceLayer("ToggleMenu: Buff Toggle Menu", 
						DrawToggleMenuUI, InterfaceScaleType.UI));
				}
			}
		}

		private bool DrawToggleMenuUI()
		{
			ToggleMenuUI.Instance.Draw(Main.spriteBatch);
			return true;
		}
	}
}
