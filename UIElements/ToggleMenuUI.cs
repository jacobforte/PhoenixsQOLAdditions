using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.UI;

namespace PhoenixsQOLAdditions.UIElements
{
	internal class ToggleMenuUI : UIState
	{
		public static ToggleMenuUI Instance;
		public DragableUIPanel Panel;
		private float oldScale;

		public override void OnInitialize()
		{
			Panel = new DragableUIPanel();
			Panel.Left.Set(603, 0);
			Panel.Top.Set(86, 0);
			Panel.Height.Set(100, 0);
			Panel.Width.Set(475, 0);

			var dangerTexture = PhoenixsQOLAdditions.Instance.Assets.Request<Texture2D>("UIElements/DangerBuffEnabled", AssetRequestMode.ImmediateLoad);
			var dangerBuffsToggle = new UIToggleImageButton(dangerTexture, PhoenixsQOLAdditions.DangerBuffsEnabled);
			dangerBuffsToggle.OnToggle += (value) => { PhoenixsQOLAdditions.DangerBuffsEnabled = value; };
			Panel.Append(dangerBuffsToggle);

			Append(Panel);
		}

		public override void Update(GameTime gameTime)
		{
			base.Update(gameTime);
			if (oldScale != Main.inventoryScale)
			{
				oldScale = Main.inventoryScale;
				Recalculate();
			}
		}
	}
}
